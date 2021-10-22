<?php
    session_start();
    include 'conexao.php';

    $codigo = "0";
    $produto = "";
    $descricao = "";
    $estoque = "";
    $preco = "0";
    $frete = "0";

    if(isset($_GET['prd']))
    {
        $cSQL = "SELECT * FROM produto WHERE PRDCODIGO = " . $_GET['prd'] . " AND PRDVISIVEL = 1";
        $oDados = mysqli_query($oCon, $cSQL);
        while($vReg = mysqli_fetch_assoc($oDados))
        {
            $codigo = $vReg['PRDCODIGO'];
            $produto = $vReg['PRDNOME'];
            $descricao = $vReg['PRDDESCRICAO'];
            $estoque = $vReg['PRDESTOQUE'];
            $preco = $vReg['PRDVENDA'];
        }
        mysqli_free_result($oDados);
    }
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/produto.css">
    <link rel="stylesheet" href="JQZOOM-MASTER/css/jquery.jqzoom.css">
    <link rel="icon" href="IMG/icon.png">
    <title>Produto</title>
</head>

<body>
    <?php include 'cabecalho.php';?>
    <main class="corpo">
        <section class="sec-prod">
            <div class="zoom">
                <div class="clearfix" id="content">
                    <div class="clearfix">
                        <a href="IMG/<?php echo isset($_GET['prd'])?"foto$codigo.png":"cart16.png"; ?>" class="jqzoom"
                            rel='gal1' title="triumph">
                            <img class="imgprod"
                                src="IMG/<?php echo isset($_GET['prd'])?"foto$codigo.png":"cart16.png";  ?>"
                                onerror="this.src='IMG/cart16.png';document.getElementsByClassName('jqzoom')[0].href='IMG/cart16.png';">
                        </a>
                    </div>
                </div>
            </div>
            <div class="dados-prod">
                <div class="nome">
                    <h2><?php echo $produto; ?></h2>
                </div>
                <div class="codigo">
                    <p>Código: <?php echo $codigo; ?></p>
                </div>
                <div class="descricao">
                    <span>Descrição: <?php echo $descricao; ?></span>
                </div>
                <?php $nCont = 1; ?>
                <div class="formulario">
                    <form id="frm" action="">
                        <button class="<?php echo $nCont; ?>" id="btnMenos" type="button" onclick="fnMenos(this.className);">-</button>
                        <input class="<?php echo $nCont; ?>" type="number" name="txtQuantidade" readonly
                            value="<?php echo isset($_GET['txtQuantidade'])?$_GET['txtQuantidade']:'1' ?>" min="1"
                            max="<?php echo $estoque; ?>" id="txtQtde">
                        <input class="<?php echo $nCont; ?>" type="hidden" name="prd" value="<?php echo $codigo; ?>">
                        <input class="<?php echo $nCont; ?>" type="hidden" name="txtValor" step="0.01"
                            value="<?php echo $preco; ?>">
                        <button class="<?php echo $nCont; ?>" id="btnMais" type="button" onclick="fnMais(this.className, <?php echo $estoque; ?>);">+</button>
                        <button name="comprar" class="confirma" type="submit"></button>
                        <?php if(isset($_SESSION['USRCODIGO'])){
                            ?>
                                <select name="slcEndereco" id="slcEndereco" class="slcEnd">
                                    <option value="0" disabled>Selecione um endereço para entrega</option>
                                    <?php
                                        $cSQL = "SELECT * FROM endereco WHERE ENDUSUARIO = " . $_SESSION['USRCODIGO'];
                                        $oEndereco = mysqli_query($oCon, $cSQL);
                                        while($vEnd = mysqli_fetch_assoc($oEndereco))
                                        {
                                            //echo $_SESSION['ENDERECO'];
                                            //echo mysqli_error($oCon);
                                            echo '<option value="' . $vEnd['ENDCODIGO'] . '" title="'.$vEnd['ENDLOGRADOURO'] . ' ' . $vEnd['ENDNUMERO'] . ' ' . $vEnd['ENDCOMPL']  . "\n\r" . $vEnd['ENDBAIRRO'] . ' - ' . $vEnd['ENDCIDADE'] . '(' . $vEnd['ENDESTADO'] . ')'."\n\r" . $vEnd['ENDCEP'] . '"'. ((isset($_SESSION['ENDERECO']) && $_SESSION['ENDERECO'] == $vEnd['ENDCODIGO'])?' selected':'') .'>' . $vEnd['ENDLOGRADOURO'] . ' ' . $vEnd['ENDNUMERO'] . " " . $vEnd['ENDCOMPL'] . '</option>';
                                        }
                                        mysqli_free_result($oEndereco);
                                    ?>
                                </select>
                            <?php
                        }?>
                        
                    </form>
                </div>
                <div class="valores">
                    <h1 id="<?php echo $nCont; ?>">
                        R$&nbsp;<?php echo isset($_GET['txtQuantidade'])?number_format(($_GET['txtQuantidade']*$preco), 2, ',', '.'):number_format($preco, 2, ',', '.'); ?>
                    </h1>
                </div>
                <div class="carrinho">
                    <?php if(isset($_SESSION['USRCODIGO'])){ 
                        echo '<button class="btnComprar" onclick="fnComprar();">COMPRAR AGORA</button>';?>
                        <form class="frmMercadoPago" action="controllers/PaymentControler.php" method="POST">
                        <script class="scriptMP"
                            src="https://www.mercadopago.com.br/integrations/v1/web-tokenize-checkout.js"
                            data-public-key="TEST-33386936-95dd-4df7-bfe2-55a8a6d631e7"
                            data-transaction-amount="<?php echo isset($_GET['txtQuantidade'])?($_GET['txtQuantidade']*$preco)+$frete:($frete + $preco) ?>"
                            data-summary-product="<?php echo isset($_GET['txtQuantidade'])?($_GET['txtQuantidade']*$preco):($preco); ?>"
                            data-summary-shipping="<?php echo $frete; ?>"
                            data-summary-product-label="<?php echo isset($_GET['txtQuantidade'])?($produto . '/x' . $_GET['txtQuantidade']):$produto ?>"
                            data-max-installemnts=3 
                            data-button-label="COMPRAR AGORA">
                        </script>
                        <?php //echo isset($_GET['txtQuantidade'])?$_GET['txtQuantidade']:'1' ?>
                    </form><?php
                    }
                    else{
                        echo '<button class="btnComprar" onclick="fnCliente();">COMPRAR AGORA</button>';
                    }
                    ?>
                    <button class="btn-carrinho" onclick="fnAddCarrinho('<?php echo $codigo; ?>');">
                        ADICIONAR AO CARRINHO
                    </button>
                </div>
            </div>
        </section>
    </main><br>
    
    <?php include 'rodape.php';?>
</body>
<script>

    <?php
    if(isset($_GET['comprar'])){
        //var_dump($_SESSION['PRODUTOS']);
    ?>
        document.getElementsByClassName('mercadopago-button')[0].click();
    <?php
    }
    ?>

    function fnComprar()
    {
        let oRetorno = new XMLHttpRequest();
        oRetorno.open('GET', 'controllers/sessao-produtos.php?produtos[]=<?php echo $codigo; ?>&quantidade[]=' + document
            .getElementsByName('txtQuantidade')[0].value);
        oRetorno.send();
        oRetorno.onload = function () {
            //alert(oRetorno.responseText);
        };

        let oRetorn = new XMLHttpRequest();
        oRetorn.open('GET', 'controllers/sessao-endereco.php?endereco=' + document.all.slcEndereco.value);
        oRetorn.send();
        oRetorn.onload = function () {
            alert(oRetorn.responseText);
        };

        document.all.comprar.click();
    } 

    function fnCliente() {
        alert('Para comprar agora você precisa estar logado!');
    }

    function fnAddCarrinho(produto) {
        let oRetorno = new XMLHttpRequest();
        oRetorno.open('GET', 'processa-carrinho.php?txtAcao=1&txtProduto=' + produto + '&txtQuantidade=' + document
            .getElementsByName('txtQuantidade')[0].value);
        oRetorno.send();
        oRetorno.onload = function () {
            let situacao = JSON.parse(oRetorno.responseText);
            alert(situacao.mensagem);
        };
    }

    function fnMais(posicao, maximo) {
        if (parseInt(document.getElementsByClassName(posicao)[1].value) != maximo) {
            let qtde = parseInt(document.getElementsByClassName(posicao)[1].value) + 1;
            let valor = parseFloat(document.getElementsByClassName(posicao)[3].value).toFixed(2)

            document.getElementsByClassName(posicao)[1].value = qtde;
            document.getElementById(posicao).innerHTML = ('R$&nbsp;' + (valor * qtde).toFixed(2));
        } else {
            alert('Produto não suficiente no estoque, desculpe');
        }
    }

    function fnMenos(posicao) {
        if (parseInt(document.getElementsByClassName(posicao)[1].value) != 1) {
            let qtde = parseInt(document.getElementsByClassName(posicao)[1].value) - 1;
            let valor = parseFloat(document.getElementsByClassName(posicao)[3].value).toFixed(2);

            document.getElementsByClassName(posicao)[1].value = qtde;
            document.getElementById(posicao).innerHTML = ('R$&nbsp;' + (qtde * valor).toFixed(2));
        } else {
            alert('Não pode escolher menos que 1!');
        }
    }
</script>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"
    integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous">
</script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"
    integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous">
</script>
<script src="JQZOOM-MASTER/js/jquery-1.5.js" type="text/javascript"></script>
<script src="JQZOOM-MASTER/js/jquery.jqzoom-core.js" type="text/javascript"></script>
<script src="JS/ELEMENTOS/zoom.js"></script>
<?php

mysqli_close($oCon);
?>

</html>