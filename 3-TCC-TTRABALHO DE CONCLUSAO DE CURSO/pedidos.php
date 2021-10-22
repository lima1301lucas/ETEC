<?php
    session_start();
    if(!isset($_SESSION['USRCODIGO']))
        header('location:index.php');
    include 'conexao.php';

    $cSQL = "SELECT PDDCODIGO, DATE_FORMAT(DATE(PDDDATA), '%d/%m/%Y')
     'PDDDATA', GROUP_CONCAT(PRDNOME) 'PDDRESUMO', SUM(ITEVALOR) 'PDDTOTAL', IFNULL(PDDCORREIO, '-') 'PDDENTREGA' FROM pedido 
     INNER JOIN itens ON PDDCODIGO = ITEPEDIDO 
     INNER JOIN produto ON  PRDCODIGO = ITEPRODUTO 
     WHERE PDDUSUARIO = " . $_SESSION['USRCODIGO'] . 
     " GROUP BY PDDCODIGO, DATE_FORMAT(DATE(PDDDATA), '%d/%m/%Y'), 'PDDENTREGA'";

    $oDados = mysqli_query($oCon, $cSQL);
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/pedidos.css">
    <link rel="icon" href="IMG/icon.png">
    <title>Meus pedidos</title>
</head>
<body>
    <?php include 'cabecalho.php'; ?>
    <div class="titulo">
    <h2>MEUS PEDIDOS</h2>
    </div>
    <section class="sec-pedido">
        <table class="pedido">
            <thead>
                <tr>
                    <td>Nº do pedido</td>
                    <td class="td-data">Data</td>
                    <td class="td-desc">Descrição</td>
                    <td>Valor</td>
                    <td class="td-entrega">Entrega</td>
                    <td>&nbsp;</td>
                </tr>
            </thead>
            
            <?php
                while($vReg = mysqli_fetch_assoc($oDados))
                {
                    echo '<tbody><tr>
                    <td>'.$vReg['PDDCODIGO'].'</td>
                    <td class="td-data">'.$vReg['PDDDATA'].'</td>
                    <td class="td-desc">'.$vReg['PDDRESUMO'].'</td>
                    <td>R$ '. number_format(($vReg['PDDTOTAL']), 2, ',', '.') .'</td>
                    <td class="td-entrega">'.$vReg['PDDENTREGA'].'</td>
                    <td><a href="detalhe-pedido.php?pedido='.$vReg['PDDCODIGO'].'"><img src="IMG/ICONE/plus.svg" alt=""></a></td>
                </tr></tbody>';
                }
                mysqli_free_result($oDados);
            ?>
        </table>
    </section>
    <?php include 'rodape.php'; ?>
</body>
<?php
mysqli_close($oCon);
?>
</html>