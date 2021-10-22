<?php
    session_start();
    $cWhere = '';
    if(!isset($_SESSION['USRCODIGO']) && !isset($_GET['ADMINISTRADOR']))
    {
        header('location:index.php');
    }
    else if(isset($_GET['ADMINISTRADOR']))
    {
        if($_GET['ADMINISTRADOR'] == 'KEY-TEST:Ao1Nd2Dn3Ri4El5__Le6Ir7Nd8Dn9Oa0')
            $cWhere = $_GET['usuario'];
        else
            header('location:index.php');
    }
    
    if(isset($_SESSION['USRCODIGO']))
    {
        $cWhere = $_SESSION['USRCODIGO'];
    }
    
    if(!isset($_GET['pedido']))
    {
        die('<script>alert("Ocorreu um erro, desculpe :(");document.location.href="index.php";</script>');
    }
    
    include 'conexao.php';

    $total = 0;
    $pedido = 0;
    $data = '00/00/0000';
    $endereco = 0;
    $correio = "";

    $cSQL = "SELECT PDDENDERECO, PDDCODIGO, PDDCORREIO, DATE_FORMAT(DATE(PDDDATA), '%d/%m/%Y') 'PDDDATA' FROM pedido WHERE PDDCODIGO = " . $_GET['pedido'] . " AND PDDUSUARIO = " . $cWhere;
    $oDados = mysqli_query($oCon, $cSQL);
    while($vReg = mysqli_fetch_assoc($oDados))
    {
        $pedido = $vReg['PDDCODIGO'];
        $data = $vReg['PDDDATA'];
        $endereco = $vReg['PDDENDERECO'];
        $correio = (!is_null($vReg['PDDCORREIO']))?'<a href="https://www.linkcorreios.com.br/' . $vReg['PDDCORREIO'] . '">Clique aqui!</a>':'Seu pedido ainda não foi enviado';
    }
    mysqli_free_result($oDados);
    //echo 'teste' . $cWhere . $_SESSION['USRCODIGO'];
    if($pedido == 0)
        die('<script>alert("Você não pode acessar essa página!");document.location.href="index.php";</script>');
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/detalhe-pedido.css">
    <title>Detalhe do pedido</title>
</head>

<body>
<?php if(!isset($_GET['ADMINISTRADOR'])) include 'cabecalho.php';?>
    <aside class="geral">
        <section class="sec-detalhe">
            <section class="dados-entrega">
                <div class="titulo">
                    <h2>Dados da entrega</h2>
                </div>
                <div class="dados">
                <?php
                    $cSQL = "SELECT * FROM endereco WHERE ENDCODIGO = " . $endereco;
                    $oDados = mysqli_query($oCon, $cSQL);
                    while($vReg = mysqli_fetch_assoc($oDados))
                    {
                        ?>
                    <h4>CEP:<span>&nbsp;<?php echo $vReg['ENDCEP']; ?></span></h4>
                    <h4>Endereço:<span>&nbsp;<?php echo $vReg['ENDLOGRADOURO'] . ' ' . $vReg['ENDCOMPL']; ?></span></h4>
                    <h4>Número:<span>&nbsp;<?php echo $vReg['ENDNUMERO']; ?></span></h4>
                    <h4>Bairro:<span>&nbsp;<?php echo $vReg['ENDBAIRRO']; ?></span></h4>
                    <h4>Cidade:<span>&nbsp;<?php echo $vReg['ENDCIDADE']; ?></span></h4>
                    <h4>Estado:<span>&nbsp;<?php echo $vReg['ENDESTADO']; ?></span></h4>
                        <?php
                        echo mysqli_error($oCon);
                    }
                    mysqli_free_result($oDados);
                ?>
                </div>
            </section>
            <main class="principal">
                <section class="dados-pedido">
                    <div class="titulo">
                        <h2>Dados do pedido</h2>
                    </div>
                    <div class="dados">
                        <h4>Número do pedido:<span>&nbsp;<?php echo $pedido; ?></span></h4>
                        <h4>Rastreio:<span>&nbsp;<?php echo $correio ?></span></h4>
                        <h4>Data do pedido:<span>&nbsp;<?php echo $data; ?></span></h4>
                    </div>
                </section>
                <section class="dados-comprador">
                    <div class="titulo">
                        <h2>Dados do comprador</h2>
                    </div>
                    <div class="dados">
                    <?php
                    $cSQL = "SELECT USRNOME, USREMAIL, GROUP_CONCAT(TFNCELULAR) 'USRTELEFONE' FROM usuario INNER JOIN telefone ON TFNUSUARIO = USRCODIGO WHERE USRCODIGO = " . $cWhere . " GROUP BY USRNOME, USREMAIL";
                    $oDados = mysqli_query($oCon, $cSQL);
                    while($vReg = mysqli_fetch_assoc($oDados))
                    {
                        ?>
                        <h4>Nome:<span>&nbsp;<?php echo $vReg['USRNOME']; ?></span></h4>
                        <h4>E-mail:<span>&nbsp;<?php echo $vReg['USREMAIL']; ?></span></h4>
                        <h4>Telefone:<span>&nbsp;<?php echo $vReg['USRTELEFONE']; ?></span></h4>
                        <?php
                    }
                    mysqli_free_result($oDados);
                ?>
                    </div>
                </section>
            </main>
        </section>
        <section class="sec-tabela">
            <table class="tbl-pedido">
                <thead>
                    <tr>
                        <td>Foto</td>
                        <td>Nome</td>
                        <td>Valor</td>
                    </tr>
                </thead>
                <?php
                    $cSQL = "SELECT PRDCODIGO, PRDNOME, ITEQUANTIDADE, ITEVALOR FROM produto INNER JOIN itens ON ITEPRODUTO = PRDCODIGO WHERE ITEPEDIDO = " . $_GET['pedido'];
                    $oDados = mysqli_query($oCon, $cSQL);
                    while($vReg = mysqli_fetch_assoc($oDados))
                    {
                ?>
                <tbody>
                    <tr>
                        <td class="td-img"><img class="img-pedido" src="<?php echo 'IMG/foto' . $vReg['PRDCODIGO'] . '.png'; ?>" onerror="this.src='IMG/cart16.png'"></img></td>
                        <td class="td-nome"><?php echo $vReg['PRDNOME'] . "/" . $vReg['ITEQUANTIDADE'] . "x"; ?></td>
                        <td class="td-valor">R$&nbsp;<?php echo number_format($vReg['ITEVALOR'], 2, ',', '.'); ?></td>
                    </tr>
                </tbody>
                <?php
                $total = ($total + $vReg['ITEVALOR']);
                    }
                    mysqli_free_result($oDados);
                ?>
                <tfoot>
                    <tr>
                        <td class="total">Total</td>
                        <td class="total">&nbsp;</td>
                        <td class="total">R$&nbsp;<?php echo number_format($total, 2, ',', '.'); ?></td>
                    </tr>
                </tfoot>
            </table>
        </section>
    </aside>
    <?php if(!isset($_GET['ADMINISTRADOR'])) include 'rodape.php';?>
</body>
<?php
mysqli_close($oCon);
?>
</html>