<?php
session_start();
include 'conexao.php';
$categoria = "<br>OPS, ALGO DEU ERRADO :(";
if(isset($_GET['cat']))
{
    $oDados = mysqli_query($oCon, "SELECT CTGNOME FROM categoria WHERE CTGCODIGO = " . $_GET['cat']);
    while($vLinha = mysqli_fetch_assoc($oDados))
    {
        $categoria = $vLinha['CTGNOME'];
    }
    mysqli_free_result($oDados);
}
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/categoria.css">
    <link rel="icon" href="IMG/icon.png">
    <title>Loja Pigmeu</title>
</head>

<body>
    <?php include 'cabecalho.php';?>
    <main class="corpo">
        <section class="sec-categoria">
            <div class="titulo">
                <h2><?php echo $categoria; ?></h2>
            </div>
            <section class="categoria">
                <?php
                if(isset($_GET['cat']))
                {
                    $cSQL = "SELECT PRDCODIGO, PRDNOME, PRDVENDA FROM produto WHERE PRDCATEGORIA = " . $_GET['cat'] . " AND PRDVISIVEL = 1 AND PRDESTOQUE > 10";
                    $oProdutos = mysqli_query($oCon, $cSQL);
                    while($vLinha = mysqli_fetch_assoc($oProdutos))
                    {
                        echo '<div class="produto">
                            <div class="img-produto">
                                <img class="ft-produto" src="IMG/foto'. $vLinha['PRDCODIGO'] .'.png" style="width:100%;height:100%;" onerror="this.src=\'IMG/cart16.png\';">
                            </div>
                            <div class="info">
                                <p class="nome">'. $vLinha['PRDNOME'] .'</p>
                                <p class="valor">R$&nbsp;'. number_format($vLinha['PRDVENDA'], 2, ',', '.') .'</p>
                            </div>
                            <div class="ver">
                                <button>
                                    <a href="produto.php?prd='. $vLinha['PRDCODIGO'] .'">Ver produto</a>
                                </button>
                            </div>
                        </div>';
                    }
                    mysqli_free_result($oProdutos);
                }
                else
                    echo "Desculpe, entre em contato conosco para relatar um bug, diga o nome da página e como chegou aqui, obrigado!";
                mysqli_close($oCon);
                ?>
            </section>
        </section>
    </main>
    <?php include 'rodape.php';?>
</body>

</html>