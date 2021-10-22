<?php

    include 'conexao.php';

    $email = null;

    if(isset($_POST['btnEnviar']))
    {
        $cSQL = "SELECT 'EXISTE' FROM usuario WHERE USREMAIL = '" . $_POST['txtEmail'] . "'";
        $oDados = mysqli_query($oCon, $cSQL);
        if($vReg = mysqli_fetch_assoc($oDados))
        {
            $email = $_POST['txtEmail'];
            echo "<script>alert('Enviaremos um link para trocar a senha no seu email!');</script>";
        }
        else
        {
            echo "<script>alert('Parece que você digitou o email errado :(');</script>";
            echo mysqli_error($oCon);
        }
        mysqli_free_result($oDados);
    }
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/senha.css">
    <link rel="icon" href="IMG/icon.png">
    <title>Troca de senha</title>
</head>

<body>
    <?php include 'cabecalho.php'; ?>
    <main>
        <div class="titulo">
            <h2>ESQUECI A SENHA</h2>
        </div>
        <section class="sec-solicita-senha">
            <div class="subtitulo">
                <p>Digite o e-mail para solicitar a troca de senha</p>
            </div>
            <form name="frmEmail" action="" method="POST">
                <div class="formulario">
                    <div class="email">
                        <label>E-mail: </label>
                        <input class="inp-email" type="email" name="txtEmail" required
                            pattern="^\w.{2,}\u0040[a-z]{2,}.[a-z]{2,}\S" title="Formato esperado: seuemail@email.com">
                    </div>
                    <button class="btn-solicita" type="submit" name="btnEnviar">Enviar</button>
                </div>
            </form>
        </section>
    </main>
    <?php include 'rodape.php'; ?>
</body>
<script>
    <?php
    if (!is_null($email)) {
        ?>
    document.all.frmEmail.action
    =
    "email.php";
    document.all.txtEmail.value
    =
    "<?php echo $email; ?>";
    document.all.frmEmail.submit();
    <?php
    } 
    ?>
</script>
<?php
mysqli_close($oCon);
?>

</html>