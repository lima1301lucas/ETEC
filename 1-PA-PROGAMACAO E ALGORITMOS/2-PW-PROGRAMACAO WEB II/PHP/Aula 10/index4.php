<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css.css" class="css">
    <title>Quarta etapa</title>
</head>
<body>
    <h2>Dados digitados</h2>

    <div class="form">

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
            echo "<br>O seu login é : " . $_POST["username"];
        ?>

        <h2>Fim do cadastro, obrigado!</h2>
    </div>
</body>
</html>
