<?php 
    session_start();

    $cMsg = "";

    if(isset($_SESSION['DEUBOSTA']))
    {
        unset($_SESSION['DEUBOSTA']);
        $cMsg = '<div class="Erro"><p>Não foi possível fazer login! Usuário e/ou senha incorretos.</div>';
    }
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/login.css">
    <link rel="icon" href="IMG/icon.png">
    <title>Login</title>
</head>
<body>
    <div class="volta">
        <a href="index.php">
            <img src="IMG/ICONE/x-circle.svg">
        </a>
    </div>
    <main>
        <aside>
            <div class="info">
                <h2 class="info-titulo">Bem vindo ao e-commerce Pigmeu!</h2>
                <h4 class="desq">A sua loja do instagram agora em e-commerce, para compras com os melhores produtos, preços e atendimento.</h4>
            </div>
            <button>
                <a href="cadastro.php">Novo usuário</a>
            </button>
            <button>
                <a href="solicita-senha.php">Esqueci a senha</a>
            </button>
        </aside>
        <section class="section-log">
            <form action="processa-login.php" method="post">
                <label class="esp"><span>Usuário ou E-mail</span>
                    <input type="text" name="txtNome" class="inp-geral" autocomplete="off" onkeyup="fnErro()" required>
                </label>
                <label class="esp"><span>Senha</span>
                    <input type="password" id="pass" name="txtSenha" class="inp-senha" onkeyup="fnErro()" required>
                    <img src="IMG/ICONE/eye.svg" class="eye" id="olho" onclick="mostra_pass()">
                </label>
                <input type="hidden" name="txtPagina" value="<?php echo $_SERVER['REQUEST_URI']; ?>">
                <button type="submit" class="btnEnviar">ENTRAR</button>
            </form>
        </section>
    </main>
    <?php echo $cMsg; ?>
</body>
<script>
    function fnErro()
    {
        document.getElementsByClassName('Erro')[0].style.display = 'none';
    }
</script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
<script src="JS/ELEMENTOS/ver_senha.js"></script>

</html>
