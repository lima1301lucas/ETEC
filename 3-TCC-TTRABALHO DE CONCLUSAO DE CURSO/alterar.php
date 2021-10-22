<?php
    session_start();
    include 'conexao.php';
    $vDados = array();
    if(isset($_SESSION['USRCODIGO']))
    {
        $cSQL = "SELECT USRCPF, USREMAIL, USRNOME, USRUSUARIO FROM usuario WHERE USRCODIGO = " . $_SESSION['USRCODIGO'];
        $oDados = mysqli_query($oCon, $cSQL);
        if(!$vReg = mysqli_fetch_assoc($oDados))
        {
            $vDados = array();
        }
        else
        {
            $vDados['USRCPF'] = $vReg['USRCPF'];
            $vDados['USREMAIL'] = $vReg['USREMAIL'];
            $vDados['USRNOME'] = $vReg['USRNOME'];
            $vDados['USRUSUARIO'] = $vReg['USRUSUARIO'];
        }
        mysqli_free_result($oDados);

        $cSQL = "SELECT TFNCELULAR FROM telefone WHERE TFNUSUARIO = " . $_SESSION['USRCODIGO'];
        $oDados = mysqli_query($oCon, $cSQL);
        $i = 0;
        while($vReg = mysqli_fetch_assoc($oDados))
        {
            $vDados['TFNCELULAR'][$i] = $vReg['TFNCELULAR'];
            $i++;
        }
        mysqli_free_result($oDados);

        $cSQL = "SELECT ENDCEP, ENDNUMERO, ENDCOMPL FROM endereco WHERE ENDUSUARIO = " . $_SESSION['USRCODIGO'];
        $oDados = mysqli_query($oCon, $cSQL);
        while($vReg = mysqli_fetch_assoc($oDados))
        {
            $vDados['ENDCEP'] = $vReg['ENDCEP'];
            $vDados['ENDNUMERO'] = $vReg['ENDNUMERO'];
            $vDados['ENDCOMPL'] = $vReg['ENDCOMPL'];
        }
        mysqli_free_result($oDados);
    }
    else
    {
        echo "<script>alert('Você não tem permissão para acessar essa página!');window.location.href='index.php';</script>";
    }

    if(!isset($vDados['USRCPF']))
    {
        $vDados['USRCPF'] = "";
        $vDados['USREMAIL'] = "";
        $vDados['USRNOME'] = "";
        $vDados['USRUSUARIO'] = "";
        $vDados['TFNCELULAR'][0] = "";
        $vDados['TFNCELULAR'][1] = "";
        $vDados['ENDCEP'] = "";
        $vDados['ENDNUMERO'] = "";
        $vDados['ENDCOMPL'] = "";
    }

    if(!isset($vDados['TFNCELULAR'][1]))
    {
        $vDados['TFNCELULAR'][1] = $vDados['TFNCELULAR'][0];
        $vDados['TFNCELULAR'][0] = "";
    }

    if(!isset($vDados['ENDCEP']))
    {
        $vDados['ENDCEP'] = "";
        $vDados['ENDNUMERO'] = "";
        $vDados['ENDCOMPL'] = "";
    }
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Alterar Cadastro</title>    
    <link rel="icon" href="IMG/icon.png">
    <link rel="stylesheet" href="CSS/cadastro.css">
</head>

<body>
    <?php include 'cabecalho.php' ?>
    <main>
    <div class="titulo">
        <h2>ALTERAR CADASTRO</h2>
    </div>
    <section class="box-cadastro">
        <form action="processa-alteracao.php" method="post" class="cadastro">
            <div class="formulario">
                <div class="dados-pessoais">
                    <div class="subtitulo">
                        <p>Dados pessoais</p>
                    </div>
                    <div class="divide">
                        <div class="cpf">
                            <label>*CPF: </label>
                            <input class="inp-cpf" type="text" name="txtCPF" maxlength="11" value="<?php echo $vDados['USRCPF']; ?>" required onkeyup="fnBuscarUser()">
                        </div>
                        <div class="email">
                            <label>*E-mail: </label>
                            <input class="inp-email" type="email" name="txtEmail"
                                value="<?php echo $vDados['USREMAIL']; ?>" required
                                pattern="^\w.{2,}\u0040[a-z]{2,}.[a-z]{2,}\S"
                                title="Formato esperado: seuemail@email.com" onkeyup="fnBuscarUser()">
                        </div>
                    </div>
                    <div class="nome">
                        <label>*Nome: </label>
                        <input class="inp-nome" type="text" name="txtNome" value="<?php echo $vDados['USRNOME']; ?>" required>
                    </div>
                    <div class="divide">
                        <div class="telefone">
                            <label>Telefone: </label>
                            <input class="inp-tel" type="text" name="txtTelefone" maxlength="15"
                                value="<?php echo $vDados['TFNCELULAR'][0]; ?>"
                                onkeyup="mascara( this, mtel );">
                        </div>
                        <div class="celular">
                            <label>*Celular: </label>
                            <input class="inp-cel" type="text" name="txtCelular" maxlength="15" 
                                value="<?php echo $vDados['TFNCELULAR'][1]; ?>" required
                                onkeyup="mascara( this, mtel );">
                        </div>
                    </div>
                    <div class="usuario">
                        <label>*Usuário:
                            <input class="inp-usuario" type="text" name="txtUsuario" required value="<?php echo $vDados['USRUSUARIO']; ?>" onkeyup="fnBuscarUser()">
                        </label>
                    </div>
                    <input type="hidden" name="txtTroca" value="n">
                    <details style="margin: 15px 0px" ontoggle='fnTrocarSenha(this.open);'>
                    <summary style="outline: none;">Trocar senha</summary>
                    <div class="novaSenha">
                        <div class="divide">
                            <div class="senha">
                                <label>*Senha atual: </label>
                                <input class="inp-senhas" type="password" name="txtSenhaAntiga">
                                <img src="IMG/ICONE/blackeye.svg" class="mostra" id="olho" onclick="mostra_pass()">
                            </div>
                        </div>
                        <div class="divide">
                            <div class="senha">
                                <label>*Nova senha: </label>
                                <input class="inp-senhas" type="password" name="txtSenha" id="pass" onkeyup="verifica();validarSenha('pass','con-pass');"
                                    onkeyup="validarSenha('pass','con-pass')">
                                <img src="IMG/ICONE/blackeye.svg" class="mostra" id="olho" onclick="mostra_pass()">
                            </div>
                            <table id="mostra"></table>
                        </div>
                        <div class="divide">
                            <div class="confirmar-senha">
                                <label>*Confirme sua nova senha: </label>
                                <input class="inp-confirmar-senha" type="password" id="con-pass" name="confirmar_senha"
                                    onkeyup="validarSenha('pass','con-pass')">
                                <img src="IMG/ICONE/blackeye.svg" class="mostra" id="con-olho">
                            </div>
                            <table id="mostra-con"></table>
                        </div>
                    </div>
                    </details>
                    
                </div>
                <div class="dados-entrega">
                    <div class="subtitulo">
                        <p>Dados da entrega</p>
                    </div>
                    <div class="endereco">
                        <label>*Endereço: </label>
                        <input class="inp-endereco" type="text" name="txtEndereco" readonly style="background-color:#c0c0c0;">
                    </div>
                    <div class="divide">
                        <div class="cep">
                            <label>*CEP: </label>
                            <input class="inp-cep" type="text" name="txtCep" maxlength="8" 
                                value="<?php echo $vDados['ENDCEP']; ?>" 
                                onkeyup="if(this.value.length > 7)FnBuscarEndereco(this.value);else fnLimpa();" required>
                        </div>
                        <div class="numero">
                            <label>*Número: </label>
                            <input class="inp-numero" type="text" name="txtNumero" value="<?php echo $vDados['ENDNUMERO']; ?>"  required>
                        </div>
                        <div class="bairro">
                            <label>*Bairro: </label>
                            <input class="inp-bairro" type="text" name="txtBairro" readonly style="background-color:#c0c0c0;">
                        </div>
                    </div>
                    <div class="complemento">
                        <label>Complemento:</label>
                        <input class="inp-complemento" type="text" value="<?php echo $vDados['ENDCOMPL']; ?>"  name="txtComplemento">
                    </div>
                    <div class="divide">
                        <div class="cidade">
                            <label>*Cidade:</label>
                            <input class="inp-cidade" type="text" name="txtCidade" readonly style="background-color:#c0c0c0;">
                        </div>
                        <div class="estado">
                            <label for="estado">*Estado:</label>
                            <select class="inp-estado" name="slcEstado" id="estado" readonly style="background-color:#c0c0c0;">
                                <option disabled selected></option>
                                <option value="AC">Acre</option>
                                <option value="AL">Alagoas</option>
                                <option value="AP">Amapá</option>
                                <option value="AM">Amazonas</option>
                                <option value="BA">Bahia</option>
                                <option value="CE">Ceará</option>
                                <option value="DF">Distrito Federal</option>
                                <option value="ES">Espírito Santo</option>
                                <option value="GO">Goiás</option>
                                <option value="MA">Maranhão</option>
                                <option value="MT">Mato Grosso</option>
                                <option value="MS">Mato Grosso do Sul</option>
                                <option value="MG">Minas Gerais</option>
                                <option value="PA">Pará</option>
                                <option value="PB">Paraíba</option>
                                <option value="PR">Paraná</option>
                                <option value="PE">Pernambuco</option>
                                <option value="PI">Piauí</option>
                                <option value="RJ">Rio de Janeiro</option>
                                <option value="RN">Rio Grande do Norte</option>
                                <option value="RS">Rio Grande do Sul</option>
                                <option value="RO">Rondônia</option>
                                <option value="RR">Roraima</option>
                                <option value="SC">Santa Catarina</option>
                                <option value="SP">São Paulo</option>
                                <option value="SE">Sergipe</option>
                                <option value="TO">Tocantins</option>
                            </select>
                        </div>
                    </div>
                    <div class="button-salva">
                        <button type="button" class="btn-enviar" id="btnEnviar" onclick="fnBotao();">SALVAR</button>
                    </div>
                </div>
            </div>
        </form>
    </section>
    <main>
    <?php include 'rodape.php' ?>
</body>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
<script type="text/javascript" src="JS/MASCARAS/mascara.js"></script>
<script type="text/javascript" src="JS/ELEMENTOS/ver_senha.js"></script>
<script type="text/javascript" src="JS/VALIDACOES/confirma_senha.js"></script>
<script type="text/javascript" src="JS/VALIDACOES/senha_forte.js"></script>
<script type="text/javascript" src="JS/VALIDACOES/endereco.js"></script>
<script type="text/javascript" src="JS/VALIDACOES/testa_cpf.js"></script>
<script>

function fnBuscarUser(){
    let user = document.getElementsByName('txtUsuario')[0].value;
    let cpf = document.getElementsByName('txtCPF')[0].value;
    let email = document.getElementsByName('txtEmail')[0].value;
    let oRetorno = new  XMLHttpRequest();
    oRetorno.open('GET', 'validacoes.php?user=' + user + '&cpf=' + cpf + '&email=' + email);
    oRetorno.send();
    oRetorno.onload = function()
    {
        let dados = JSON.parse(oRetorno.responseText);
        if((dados.usuario == "ENCONTRADO" || document.getElementsByName('txtUsuario')[0].value.length < 4) && document.getElementsByName('txtUsuario')[0].value != '<?php echo $vDados['USRUSUARIO']; ?>')
        {
            document.getElementsByName('txtUsuario')[0].style.border = "1px solid #ff0000";
        }
        else
        {
            document.getElementsByName('txtUsuario')[0].style.border = "1px solid #00ff00";
        }
        if((dados.cpf == "ENCONTRADO" || document.getElementsByName('txtCPF')[0].value.length <= 10 || TestaCPF(document.getElementsByName('txtCPF')[0].value) == false) && document.getElementsByName('txtCPF')[0].value != '<?php echo $vDados['USRCPF']; ?>')
        {
            document.getElementsByName('txtCPF')[0].style.border = "1px solid #ff0000";
        }
        else
        {
            document.getElementsByName('txtCPF')[0].style.border = "1px solid #00ff00";
        }
        if((dados.email == "ENCONTRADO" || document.getElementsByName('txtEmail')[0].validity.valid == false || document.getElementsByName('txtEmail')[0].value.length < 4) && document.getElementsByName('txtEmail')[0].value != '<?php echo $vDados['USREMAIL']; ?>')
        {
            document.getElementsByName('txtEmail')[0].style.border = "1px solid #ff0000";
        }
        else
        {
            document.getElementsByName('txtEmail')[0].style.border = "1px solid #00ff00";
        }
    }
}

function fnBotao(){
    if(document.getElementsByName('txtCep')[0].value.length > 7)
        FnBuscarEndereco(document.getElementsByName('txtCep')[0].value);
    else 
        fnLimpa();
    if((document.getElementById("mostra-con").innerHTML != '<tbody><tr><td bgcolor="green"></td><td>Senhas coincidem</td></tr></tbody>' || 
    document.getElementById("mostra").innerHTML != '<tbody><tr><td bgcolor="green" width="100"></td><td>Excelente </td></tr></tbody>')
    && document.getElementsByName('txtTroca')[0].value == 's')
    {
        document.all.btnEnviar.type = "button";
        alert("A senha precisa ser excelente e igual ao campo confirmar senha");
    }
    else if(document.getElementsByName('txtUsuario')[0].style.border != "1px solid rgb(0, 255, 0)")
    {
        document.all.btnEnviar.type = "button";
        alert("Nome de usuário inválido ou já existente");
    }
    else if(document.getElementsByName('txtCPF')[0].style.border != "1px solid rgb(0, 255, 0)")
    {
        document.all.btnEnviar.type = "button";
        alert("Este CPF é inválido ou já está cadastrado");
    }
    else if(document.getElementsByName('txtEmail')[0].style.border != "1px solid rgb(0, 255, 0)")
    {
        document.all.btnEnviar.type = "button";
        alert("Email inválido ou já cadastrado");
    }
    else if(document.getElementsByName('txtEndereco')[0].value == "" || document.getElementsByName('txtEndereco')[0].value == " ")
    {
        document.all.btnEnviar.type = "button";
        alert("Digite um CEP válido");
    }
    else
    {
        document.all.btnEnviar.type = "submit";
    }
}

function fnTrocarSenha(teste){
    if(teste == true)
    {
        document.getElementsByName('txtTroca')[0].value = 's';
    }
    else
    {
        document.getElementsByName('txtTroca')[0].value = 'n';
    }
}

FnBuscarEndereco('<?php echo $vDados['ENDCEP']; ?>');
fnBuscarUser();

</script>
<?php
mysqli_close($oCon);
?>
</html>