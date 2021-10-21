<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css.css" class="css">
    <title>Segunda etapa</title>
</head>
<body>
    <h2>Segunda etapa</h2>

    <div class="form">

    <form  method="POST" action="index3.php">

        <?php 

            $nome = $_POST["nome"];
            $email = $_POST["email"];
            $datanascimento = $_POST["datanascimento"];
            $sexo = $_POST["sexo"];
            $profissao = $_POST["profissao"];

            echo "O seu nome é: " . $_POST["nome"];
            echo "<br>O seu e-mail é: " . $_POST["email"];
            echo "<br>A data de nascimento é: " . $_POST["datanascimento"];
            echo "<br>O seu sexo é: " . $_POST["sexo"];
            echo "<br>A sua profissão é : " . $_POST["profissao"];
        ?>

        
        <input type="hidden" name="nome" value="<?php  echo $nome; ?>">
        <input type="hidden" name="email" value="<?php  echo $email; ?>">
        <input type="hidden" name="datanascimento" value="<?php  echo $datanascimento; ?>">
        <input type="hidden" value="feminino" name ="sexo" value="<?php  echo $sexo; ?>">
        <input type="hidden" name="profissao" value="<?php  echo $profissao; ?>">

       
        <div class="form">
        Telefone: <input type="text" name="telefone" size="20">
        </div>

        <div class="form">
        Endereço: <input type="text" name="endereco" size="30">
        </div>

        <div class="form">
        Cidade: <input type="text" name="cidade" &nbsp;&nbsp;>
        Estado: <input type="text" name="estado" size="2">
        </div>

        <div class="form">
        CEP: <input type="text" name="cep" size="9">
        </div>

        <input type="submit" value="Prosseguir&gt;&gt;">
        </div>

        </form>

    </div>
</body>
</html>
