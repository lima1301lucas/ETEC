<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/login.css">
    <title>Login</title>
</head>

<body>
    <main>
        <aside>
            <div class="info">
                <h2 class="desq">Bem vindo ao iMusic</h2>
                <h4>Ao fazer seu login, você consegue montar playlists, pesquisar músicas, encontar os principais artistas da atualidade, escutar podcasts e rádios.</h4>
            </div>
            <button>Novo usuário</button>
            <button>Alterar senha</button>
        </aside>
        <section class="section-login">
            <form action="usuario.php" method="post">
                <label class="esp"><span>Usuário</span>
                    <input type="text" name="txtNome" class="inp-geral" autocomplete="off">
                </label>
                <label><span>Senha</span>
                    <input type="password" name="txtSenha" class="inp-geral">
                </label>
                <input type="hidden" name="txtPagina" value="<?php echo $_SERVER['REQUEST_URI']; ?>">
                <button class="btnEnviar">Entrar</button>
            </form>
        </section>
    </main>
</body>

</html>