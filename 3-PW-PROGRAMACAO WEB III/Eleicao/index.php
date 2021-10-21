<?php 
    session_start();
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <link rel="stylesheet" href="css/login.css" class="css">
    <title>LOGIN</title>
</head>

<body>
    <div class="geral">
        <div class="titulo">
            <img src="img/log-in.svg " class="icone">
            <h1 class="subtitulo">LOGIN</h1>
        </div>
        <section class="box-login">
            <div class="container">
                <div class="form">
                    <form action="valida_login" method="POST" autocomplete="off">
                        <div class="rm">
                            <label>RM
                                <input type="text" name="rm" class="inp-rm" maxlength="5" required autocomplete="off">
                            </label>
                        </div>
                        <div class="rg">
                            <label class="lbl-rg">RG
                                <input type="text" name="rg" class="inp-rg" maxlength="12" required autocomplete="off">
                            </label>
                        </div>
                        <button type="submit" class="botao">ENTRAR</button>
                    </form>
                </div>
            </div>
    </div>
    </section>
    </div>
</body>

</html>

<!-- <?php 
    if(isset($_SESSION['LoginErro']))
    {
        echo "<script>alert('Dados não conferem!');</script>";
    }
?> -->