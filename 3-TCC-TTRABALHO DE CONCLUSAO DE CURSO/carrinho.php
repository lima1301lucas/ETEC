<?php
    session_start();
    if(!isset($_SESSION['USRCODIGO']))
        header('location:index.php');
    include 'conexao.php';

    $frete = 0;
    $preco = 0;
    $descricao = "Carrinho"
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/carrinho.css">
    <link rel="icon" href="IMG/icon.png">
    <title>Carrinho</title>
</head>

<body>
<?php include 'cabecalho.php'; ?>
<main>
    <section class="sec-carrinho">
        <table class="tbl-carrinho">
            <thead>
                <tr>
                    <td>Foto</td>
                    <td>Nome</td>
                    <td>Quantidade</td>
                    <td>Valor Unitário</td>
                    <td>&nbsp;</td>
                </tr>
            </thead>
            <?php
                $cSQL = "SELECT PRDCODIGO, PRDNOME, PRDVENDA, PRDESTOQUE, CRRQUANTIDADE FROM produto INNER JOIN carrinho ON CRRPRODUTO = PRDCODIGO WHERE CRRUSUARIO = " . $_SESSION['USRCODIGO'];
                $oDados = mysqli_query($oCon, $cSQL);
                $nCont = 1;
                $vProdutos = array();
                $vQuantidade = array();
                while($vReg = mysqli_fetch_assoc($oDados))
                {
                    $vProdutos[$nCont - 1] = $vReg['PRDCODIGO'];
                    $vQuantidade[$nCont - 1] = $vReg['CRRQUANTIDADE'];
            ?>
            <tbody>
                <tr>
                    <td class="td-img"><img src="<?php echo 'IMG/foto' . $vReg['PRDCODIGO'] . '.png'; ?>"
                            class="img-pedido" onerror="this.src='IMG/cart16.png'"></img></td>
                    <td class="td-nome"><?php echo $vReg['PRDNOME']; ?></td>
                    <td class="td-qtde">
                        <button class="<?php echo $nCont; ?>" type="button" id="menos"
                            onclick="fnMenos(this.className);">-</button>
                        <input class="<?php echo $nCont; ?>" type="number" readonly
                            value="<?php echo $vReg['CRRQUANTIDADE']; ?>" min="1"
                            max="<?php echo $vReg['PRDESTOQUE']; ?>">
                        <input class="<?php echo $nCont; ?>" type="hidden" value="<?php echo $vReg['PRDCODIGO']; ?>">
                        <input class="<?php echo $nCont; ?>" type="hidden" step="0.01"
                            value="<?php echo $vReg['PRDVENDA']; ?>">
                        <button class="<?php echo $nCont; ?>" type="button" id="mais"
                            onclick="fnMais(this.className, <?php echo $vReg['PRDESTOQUE']; ?>);">+</button>
                    </td>
                    <td id="<?php echo $nCont; ?>" class="td-valor">
                        R$&nbsp;<?php echo ($vReg['PRDVENDA']*$vReg['CRRQUANTIDADE']); ?></td>
                    <td><img src="IMG/ICONE/trash.svg" alt="" onclick="fnExcluirProduto(<?php echo $nCont; ?>)"></td>
                </tr>
            </tbody>
            <?php
                    $preco += number_format(($vReg['PRDVENDA']*$vReg['CRRQUANTIDADE']), 2, ".", "");
                    $nCont++;
                }
                mysqli_free_result($oDados);
            ?>
            <tfoot>
            <tr>
                <td class="total">Total</td>
                <td class="total">&nbsp;</td>
                <td class="total">&nbsp;</td>
                <td class="total">R$&nbsp;000,00</td>
                <td class="total">&nbsp;</td>
            </tr>
            </tfoot>
        </table>
        <div class="controle">
            <div class="volta">
                <a href="index.php">
                    <button type="button" class="mais">Comprar mais produtos</button>
                    <button type="button" class="delete" onclick="fnDeletar();">Deletar Carrinho</button>
                </a>
            </div>
            <div class="voltar">
                <form action="" method="GET">
                    <button id="btnConfirmar" type="submit" name="comprar" class="confirma">Confirmar
                        quantidade</button>
                    <select name="slcEndereco" id="slcEndereco">
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
                </form>
                <div class="finaliza">
                    <button class="btnComprar" onclick="fnComprar();" id="btn-comprar">Finalizar compra</button>
                    <form action="controllers/PaymentControler.php" method="POST">
                        <script src="https://www.mercadopago.com.br/integrations/v1/web-tokenize-checkout.js"
                            data-public-key="TEST-33386936-95dd-4df7-bfe2-55a8a6d631e7"
                            data-transaction-amount="<?php echo ($frete + $preco); ?>"
                            data-summary-product="<?php echo $preco; ?>" data-summary-shipping="<?php echo $frete; ?>"
                            data-summary-product-label="<?php echo $descricao; ?>" data-max-installemnts=3
                            data-button-label="Finalizar compra">
                        </script>
                        <?php
                $i = 0;
                $cCarrinho = "controllers/sessao-produtos.php?";
                foreach($vProdutos as $nProduto)
                {
                    $cCarrinho .= "&produtos[]=$nProduto&quantidade[]=" . $vQuantidade[$i];
                    //echo "<input type='hidden' name='txtProduto[]' value='$nProduto'/>";
                    //echo "<input type='hidden' name='txtQuantidade[]' value='" . $vQuantidade[$i] . "'/>";
                    
                    $i++;
                }
                $cCarrinho = str_replace('?&', '?', $cCarrinho);
                ?>

                    </form>
                </div>
            </div>
        </div>
    </section>
</main>
    <?php include 'rodape.php'; ?>
</body>
<script>

    <?php
    if(isset($_GET['comprar'])){
        //var_dump($_SESSION['PRODUTOS']);
    ?>
        let oRetorno = new XMLHttpRequest();
        oRetorno.open('GET', '<?php echo $cCarrinho; ?>');
        oRetorno.send();
        oRetorno.onload = function () {
            //alert(oRetorno.responseText);
        };
        document.getElementsByClassName('mercadopago-button')[0].click();
    <?php
    }
    ?>

    function fnComprar()
    {
        let oRetorn = new XMLHttpRequest();
        oRetorn.open('GET', 'controllers/sessao-endereco.php?endereco=' + document.all.slcEndereco.value);
        oRetorn.send();
        oRetorn.onload = function () {
            //alert(oRetorn.responseText);
        };
        document.all.btnConfirmar.click();
    }

    function fnMais(posicao, maximo)
    {
        if(parseInt(document.getElementsByClassName(posicao)[1].value) != maximo)
        {
            let qtde = parseInt(document.getElementsByClassName(posicao)[1].value) + 1;
            let valor = parseFloat(document.getElementsByClassName(posicao)[3].value).toFixed(2)

            document.getElementsByClassName(posicao)[1].value = qtde;
            document.getElementById(posicao).innerHTML = ('R$&nbsp;' + (valor * qtde).toFixed(2));
            let oRetorno = new  XMLHttpRequest();
            oRetorno.open('GET', 'processa-carrinho.php?txtAcao=2&txtProduto=' + document.getElementsByClassName(posicao)[2].value + '&txtQuantidade=' + qtde);
            oRetorno.send();
            oRetorno.onload = function()
            {
                let situacao = JSON.parse(oRetorno.responseText);
                //alert(situacao.mensagem);
            };
            fnTotal();
        }
        else
        {
            alert('Produto não suficiente no estoque, desculpe');
        }
    }

    function fnTotal()
    {
        let i = 1;
        let total = 0.00;
        while(i < <?php echo $nCont; ?>)
        {
            total += (document.getElementsByClassName(i)[3].value * document.getElementsByClassName(i)[1].value);
            i++;
        }
        document.getElementsByClassName('total')[3].innerHTML = 'R$&nbsp;' + (total).toFixed(2);
        //document.getElementById('total').value = (total).toFixed(2);
    }

    function fnMenos(posicao)
    {
        if(parseInt(document.getElementsByClassName(posicao)[1].value) != 1)
        {
            let qtde = parseInt(document.getElementsByClassName(posicao)[1].value) - 1;
            let valor = parseFloat(document.getElementsByClassName(posicao)[3].value).toFixed(2);

            document.getElementsByClassName(posicao)[1].value = qtde;
            document.getElementById(posicao).innerHTML = ('R$&nbsp;' + (qtde * valor).toFixed(2));
            let oRetorno = new  XMLHttpRequest();
            oRetorno.open('GET', 'processa-carrinho.php?txtAcao=2&txtProduto=' + document.getElementsByClassName(posicao)[2].value + '&txtQuantidade=' + qtde);
            oRetorno.send();
            oRetorno.onload = function()
            {
                let situacao = JSON.parse(oRetorno.responseText);
                //alert(situacao.mensagem);
            };
            fnTotal();
        }
        else
        {
            alert('Não pode escolher menos que 1!');
        }
    }

    function fnDeletar()
    {
        if(prompt('Digite "carrinho" para confirmar a limpeza do carrinho').toUpperCase() == 'CARRINHO')
        {
            let oRetorno = new  XMLHttpRequest();
            oRetorno.open('GET', 'processa-carrinho.php?txtAcao=4');
            oRetorno.send();
            oRetorno.onload = function()
            {
                let situacao = JSON.parse(oRetorno.responseText);
                alert(situacao.mensagem);
                document.location.href='carrinho.php';
            };
        }
        
    }
    
    function fnExcluirProduto(posicao)
    {
        let qtde = document.getElementsByClassName(posicao)[1].value;
        let prd = document.getElementsByClassName(posicao)[2].value;
        if(confirm('Tem certeza que deseja excluir esse produto do carrinho?'))
        {
            let oRetorno = new  XMLHttpRequest();
            oRetorno.open('GET', 'processa-carrinho.php?txtAcao=3&txtProduto=' + prd + '&txtQuantidade=' + qtde);
            oRetorno.send();
            oRetorno.onload = function()
            {
                let situacao = JSON.parse(oRetorno.responseText);
                alert(situacao.mensagem);
                document.location.href='carrinho.php';
            };
        }
    }

    function fnConfirmar()
    {
        //document.location.href='carrinho.php';
    }

    fnTotal();
</script>
<?php
mysqli_close($oCon);
?>
</html>