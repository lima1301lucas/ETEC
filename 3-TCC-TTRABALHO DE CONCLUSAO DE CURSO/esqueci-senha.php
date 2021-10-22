<?php
    include 'conexao.php';
    $cAviso = "";
    if(!isset($_GET['nCod']))
        echo "<script>alert('Você não pode acessar essa página!');window.location.href='index.php';</script>";
    else
    {
        $cSQL = "SELECT 'PERMITIDO' FROM usuario WHERE USRDTMAX > NOW() AND MD5(USRCODIGO) = '" . $_GET['nCod'] . "'";
        $oDados = mysqli_query($oCon, $cSQL);
        if(!$vReg = mysqli_fetch_assoc($oDados))
        {
            $cAviso = '<aside class="aviso"><p>Link espirou por favor solicite a troca novamente!</p></aside>';
        }
        else
        {
            if(isset($_POST['btnEnviar']))
            {
                $cSenha = str_replace('"', '\"', str_replace("'", "\'", $_POST['txtSenha']));
                $cSQL = "UPDATE usuario SET USRSENHA = MD5('" . $cSenha . "') WHERE MD5(USRCODIGO) = '" . $_POST['txtCodigo'] . "'";
                if(mysqli_query($oCon, $cSQL))
                {
                    $cAviso = '<aside class="aviso2"><p>Sua senha foi alterada com sucesso!</p></aside>';
                }
                else
                {
                    $cAviso = '<aside class="aviso"><p>Algo deu errado, não foi possível alterar a senha :(</p></aside>';
                }
            }
            
        }
    }
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/senha.css">
    <link rel="icon" href="IMG/icon.png">
    <title>Esqueci a senha</title>
</head>

<body>
    <?php include 'cabecalho.php'; ?>
    <main>
    <div class="titulo">
        <h2>TROCAR A SENHA</h2>
    </div>
    <section class="sec-troca-senha">
        <div class="subtitulo">
            <p>Digite a nova senha</p>
        </div>
        <form action="" method="POST">
            <div class="formulario">
                <div class="divide">
                    <div class="senha">
                        <label>Nova senha: </label>
                        <input class="inp-senhas" type="password" name="txtSenha" id="pass"
                            onkeyup="verifica();validarSenha('pass','con-pass');"
                            onkeyup="validarSenha('pass','con-pass')" required>
                        <img src="IMG/ICONE/blackeye.svg" class="mostra" id="olho" onclick="mostra_pass()">
                    </div>
                    <table id="mostra"></table>
                </div>
                <div class="divide">
                    <div class="confirmar-senha">
                        <label>Confirme sua senha: </label>
                        <input class="inp-confirmar-senha" type="password" id="con-pass" name="confirmar_senha"
                            onkeyup="validarSenha('pass','con-pass')" required>
                        <img src="IMG/ICONE/blackeye.svg" class="mostra" id="con-olho">
                    </div>
                    <table id="mostra-con"></table>
                </div>
            </div>
            <input type="hidden" name="txtCodigo" value="<?php echo $_GET['nCod']; ?>">
            <div class="troca">
                <button class="btn-troca" type="button" id="btnEnviar" name="btnEnviar" onclick="fnBotao();">Trocar senha</button>
            </div>
        </form>
    </section>
    <?php echo $cAviso; ?>
    </main>
    <?php include 'rodape.php'; ?>
</body>
<script>
    function fnBotao()
    {
        if(document.getElementById("mostra-con").innerHTML != '<tbody><tr><td bgcolor="green"></td><td>Senhas coincidem</td></tr></tbody>' || 
            document.getElementById("mostra").innerHTML != '<tbody><tr><td bgcolor="green" width="100"></td><td>Excelente </td></tr></tbody>')
        {
            document.all.btnEnviar.type = "button";
            alert("A senha precisa ser excelente e igual ao campo confirmar senha");
        }
        else
        {
            document.all.btnEnviar.type = "submit";
        }
    }
</script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
<script type="text/javascript" src="JS/VALIDACOES/confirma_senha.js"></script>
<script type="text/javascript" src="JS/VALIDACOES/senha_forte.js"></script>
<script type="text/javascript" src="JS/ELEMENTOS/ver_senha.js"></script>
<?php
mysqli_close($oCon);
?>
</html>