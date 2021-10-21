<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/insere-album.css">
    <title>Inserir álbum</title>
</head>

<body>
    <?php include 'cabecalho.php'; ?>
    <section class="sec-album">
        <div class="titulo">
            <h2>CADASTRO DE ÁLBUM</h2>
        </div>
        <form method="POST" enctype="multipart/form-data" accept-charset="UTF-8" autocomplete="off" class="alb">
            <div class="inputs">
                <div class="nome">
                    <label>Nome do álbum</label>
                    <input type="text" name="txtNome" class="inp-nome" autocomplete="off">
                </div>
                <div class="imagem">
                    <label>Capa
                        <input type="file" class="inp-img" name="txtArquivo" accept="image/png, image/jpeg, image/jpg" onChange="fnExibeArquivo(this)">
                    </label>
                </div>
                <div class="data">
                    <label>Data
                        <input type="date" name="txtData" class="inp-data">
                    </label>
                </div>
                <div class="artista">
                    <label>Artista
                        <select name="slcArtista" class="slcArtista">
                            <option selected value="0">Artista do álbum</option>
                            <?php 
                                include 'conexao.php';

                                $cArtista = "SELECT ARTCODIGO, ARTNOME FROM ARTISTAS ORDER BY ARTNOME ASC";
                                $cResultado = mysqli_query($oCon, $cArtista);

                                while($Vreg = mysqli_fetch_assoc($cResultado))
                                { ?>
                            <option value="<?php echo $Vreg['ARTCODIGO']; ?>">
                                <?php echo $Vreg['ARTNOME']; ?></option><?php
                                }
                                mysqli_close($oCon);
                            ?>
                        </select>
                    </label>
                </div>
                <div class="banda">
                    <label>Banda
                        <select name="slcBanda">
                            <option selected value="0">Banda do álbum</option>
                            <?php 
                                include 'conexao.php';

                                $cBanda = "SELECT BDSCODIGO, BDSNOME FROM BANDAS ORDER BY BDSNOME ASC";
                                $cResultado = mysqli_query($oCon, $cBanda);

                                while($Vreg = mysqli_fetch_assoc($cResultado))
                                { ?>
                            <option value="<?php echo $Vreg['BDSCODIGO']; ?>">
                                <?php echo $Vreg['BDSNOME']; ?></option><?php
                                }
                                mysqli_close($oCon);
                            ?>
                        </select>
                    </label>
                </div>
                <div class="genero">
                    <label>Gênero
                        <select name="slcGenero" class="slcGenero">
                            <option selected disabled>Gênero do álbum</option>
                            <?php 
                                include 'conexao.php';

                                $cGenero = "SELECT GNRCODIGO, GNRNOME FROM GENEROS ORDER BY GNRNOME ASC";
                                $cResultado = mysqli_query($oCon, $cGenero);

                                while($Vreg = mysqli_fetch_assoc($cResultado))
                                { ?>
                            <option value="<?php echo $Vreg['GNRCODIGO']; ?>">
                                <?php echo $Vreg['GNRNOME']; ?></option><?php
                                }
                                mysqli_close($oCon);
                            ?>
                        </select>
                    </label>
                </div>
                <div class="gravadora">
                    <label>Gravadora
                        <select name="slcGravadora" class="slcGravadora">
                            <option selected disabled>Gravadora do álbum</option>
                            <?php 
                                include 'conexao.php';

                                $cGravadora = "SELECT GRVCODIGO, GRVNOME FROM GRAVADORAS ORDER BY GRVNOME ASC";
                                $cResultado = mysqli_query($oCon, $cGravadora);

                                while($Vreg = mysqli_fetch_assoc($cResultado))
                                { ?>
                            <option value="<?php echo $Vreg['GRVCODIGO']; ?>">
                                <?php echo $Vreg['GRVNOME']; ?></option><?php
                                }
                                mysqli_close($oCon);
                            ?>
                        </select>
                    </label>
                </div>
                <button type="submit" class="btn">CADASTRAR</button>
            </div>
            <div class="aparece-img">
                <img src="IMG/ICONES/camera-off.svg" id="imgPrev" width="350" height="350">
            </div>
        </form>
    </section>
</body>
<script>
    function fnExibeArquivo(oArquivo) {
        if (oArquivo.files && oArquivo.files[0]) {
            let oImagem = new FileReader();

            oImagem.onload = function (oDados) {
                document.all.imgPrev.src = oDados.target.result;
            }

            oImagem.readAsDataURL(oArquivo.files[0]);
        }
    }
</script>
</html>

<?php 

if(isset($_FILES['txtArquivo'])){
    $extensao = strtolower(substr($_FILES['txtArquivo']['name'], -4));
    $ftcapa = md5(time()).$extensao;
    $diretorio = "UPLOAD/";
    move_uploaded_file($_FILES['txtArquivo']['tmp_name'],$diretorio.$ftcapa);

    $nome = $_POST['txtNome'];

    if(isset($_POST['slcArtista']))
        $artista = $_POST['slcArtista'];
    else  
        $artista = NULL;
    
    if(isset($_POST['slcBanda']))
        $banda = $_POST['slcBanda'];
    else  
        $banda = NULL;

    $genero = $_POST['slcGenero'];
    $gravadora = $_POST['slcGravadora'];
    $lancamento = $_POST['txtData'];

    include 'conexao.php';

    if($artista > 0 && $banda > 0){
        echo "<script>alert('Escolha somente artista ou somente banda!');</script>";
    }
    else{

    if(isset($artista)){
        $cASQL = "INSERT INTO ALBUNS (ALBNOME, ALBFT, ALBARTISTA, ALBGENERO, ALBGRAVADORA, ALBLANCAMENTO) VALUES ('$nome', '$ftcapa', '$artista','$genero', '$gravadora', '$lancamento')"; 
        
        if ($oCon->query($cASQL) === TRUE){
            echo "<script>alert('Álbum cadastrado!');</script>";
        }
        else{
            echo "Erro: " . $cASQL . "<br>" . $oCon->error;
        }
    }
    else{
        $cBSQL = "INSERT INTO ALBUNS (ALBNOME, ALBFT, ALBBANDA, ALBGENERO, ALBGRAVADORA, ALBLANCAMENTO) VALUES ('$nome', '$ftcapa', '$banda','$genero', '$gravadora', '$lancamento')"; 
        
        if ($oCon->query($cBSQL) === TRUE){
            echo "<script>alert('Álbum cadastrado!');</script>";
        }
        else{
            echo "Erro: " . $cBSQL . "<br>" . $oCon->error;
        }
    }
}
    $oCon->close();
}
?>
