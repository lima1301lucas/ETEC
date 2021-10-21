<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
<h1>Recebendo dados do formulário checkbox</h1>

    <?php 
    if(isset($_POST["numeros"]))
    {
        echo"Os números da sua preferência são: <br>";
        foreach($_POST["numeros"] as $numero){
            echo"- " . $numero . "<br>";
        }
    }

    else{
        echo"Não escolheu os números";
    }

    if(isset($_POST["news"])){
        echo"Receba suas mensagens por e-mail";
    }
    else{
        echo"Você não vai receber novidades por e-mail...h";
    }
       ?>
</body>
</html>