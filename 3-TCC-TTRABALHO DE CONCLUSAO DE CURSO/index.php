<?php
session_start();
include 'conexao.php';
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/index.css">
    <link rel="icon" href="IMG/icon.png">
    <title>Loja Pigmeu</title>
</head>

<body>
    <?php include 'cabecalho.php';?>
    <main class="corpo">
        <section class="sec-banner">
            <img class="ind-banner" src="IMG/banner.png">
        </section>
        <?php
            $cSQL = "SELECT CTGNOME, CTGCODIGO FROM categoria WHERE EXISTS(SELECT 0 FROM produto WHERE PRDCATEGORIA = CTGCODIGO AND PRDVISIVEL = 1 AND PRDESTOQUE > 10)";
            $oDados = mysqli_query($oCon, $cSQL);
            while($vReg = mysqli_fetch_assoc($oDados))
            {
                echo '<section class="sec-categoria">';
                echo '<div class="titulo">
                        <h2>'.$vReg['CTGNOME'].'</h2>
                    </div>
                    <section class="categoria">';
                $cSQL = "SELECT PRDCODIGO, PRDNOME, PRDVENDA FROM produto WHERE PRDCATEGORIA = " . $vReg['CTGCODIGO'] . " AND PRDVISIVEL = 1 AND PRDESTOQUE > 10 LIMIT 4";
                $oProdutos = mysqli_query($oCon, $cSQL);
                while($vLinha = mysqli_fetch_assoc($oProdutos))
                {
                    echo '<div class="produto">
                        <div class="img-produto">
                            <img class="ft-produto" src="IMG/foto'. $vLinha['PRDCODIGO'] .'.png"  onerror="this.src=\'IMG/cart16.png\';">
                        </div>
                        <div class="info">
                            <p class="nome">'. $vLinha['PRDNOME'] .'</p>
                            <p class="valor">R$&nbsp;'. number_format($vLinha['PRDVENDA'], 2, ',', '.') .'</p>
                        </div>
                        <div class="ver">
                            <a href="produto.php?prd='. $vLinha['PRDCODIGO'] .'">
                                <button>Ver produto</button>
                            </a>
                        </div>
                    </div>';
                }
                mysqli_free_result($oProdutos);
                echo '</section>
                        <div class="mais">
                            <a href="categoria.php?cat='. $vReg['CTGCODIGO']. '">
                                <img src="IMG/ICONE/seta-baixo.svg" class="seta">
                            </a>
                        </div>
                    </section>';
            }
            mysqli_free_result($oDados);
        ?>
    </main>
    <?php include 'rodape.php';?>
</body>

</html>