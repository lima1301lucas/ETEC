<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Recebe dados</title>
</head>
<body>
    <p><strong>Formulário MySQL</strong></p>

        <?php
        $cx = mysqlli_connect("192.168.0.8:3306","Aluno2DS","SenhaBD2");

        $db = mysqli_selecet_db($cx,"junicius");

            $login = $_POST["login"];
            $email = $_POST["email"];
            $cidade = $_POST["cidade"];
            $estado = $_POST["estado"];
            $comentarios = $_POST["comentarios"];
            $senha = $_POST["senha"];

            $sql = "INSERT INTO usuarios VALUES";
            $sql .="('$login', '$email', '$cidade','$estado','$comentarios','$senha')";

            if($cx->query($sql)===TRUE){
                echo "Usuário inserido com sucesso";
            }
            else 
            {
                echo "Erro: ".$sql. "<br>". $cx->error;
            }

            echo "O seu nome é: " . $_POST["login"];
            echo "<br>O seu e-mail é: " . $_POST["email"];
            echo "<br>Sua cidade é: " . $_POST["cidade"];
            echo "<br>Seu estado é: " . $_POST["estado"];
            echo "<br>O seu comentario é: " . $_POST["comentarios"];

            $cx.close();
        ?>
</body>
</html>