<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css.css" class="css">
    <title>Terceira etapa</title>
</head>
<body>
    <h2>Terceira etapa</h2>

    <div class="form">

        <form action="index4.php" method="POST">

         <?php 

            $nome = $_POST["nome"];
            $email = $_POST["email"];
            $datanascimento = $_POST["datanascimento"];
            $sexo = $_POST["sexo"];
            $profissao = $_POST["profissao"];
            $telefone = $_POST["telefone"];
            $endereco = $_POST["endereco"];
            $cidade = $_POST["cidade"];
            $estado = $_POST["estado"];
            $cep = $_POST["cep"];

            echo "O seu nome é: " . $_POST["nome"];
            echo "<br>O seu e-mail é: " . $_POST["email"];
            echo "<br>A data de nascimento é: " . $_POST["datanascimento"];
            echo "<br>O seu sexo é: " . $_POST["sexo"];
            echo "<br>A sua profissão é : " . $_POST["profissao"];
            echo "<br>O seu telefone é: " . $_POST["telefone"];
            echo "<br>O seu endereço é: " . $_POST["endereco"];
            echo "<br>A sua cidade é: " . $_POST["cidade"];
            echo "<br>O seu estado é: " . $_POST["estado"];
            echo "<br>O seu CEP é : " . $_POST["cep"];
            
        ?>

        <input type="hidden" name="nome" value="<?php  echo $nome; ?>">
        <input type="hidden" name="email" value="<?php  echo $email; ?>">
        <input type="hidden" name="datanascimento" value="<?php  echo $datanascimento; ?>">
        <input type="hidden" value="feminino" name ="sexo" value="<?php  echo $sexo; ?>">
        <input type="hidden" name="profissao" value="<?php  echo $profissao; ?>">
        <input type="hidden" name="telefone" value="<?php  echo $telefone; ?>">
        <input type="hidden" name="endereco" value="<?php  echo $endereco; ?>">
        <input type="hidden" name="cidade" value="<?php  echo $cidade; ?>">
        <input type="hidden" name="estado" value="<?php  echo $estado; ?>">
        <input type="hidden" name="cep" value="<?php  echo $cep; ?>">

        <div class="form">
        Usuário: <input type="text" name="username" size="8">
        </div>

        <div class="form">
        Senha: <input type="password" name="senha" size="4">
        </div>

        <div class="form">
        Confirmar senha: <input type="password" name="confirma_senha" size="4">
        </div>

        <input type="submit" value="Finalizar cadastro">
        </div>

        </form>

    </div>
</body>
</html>
