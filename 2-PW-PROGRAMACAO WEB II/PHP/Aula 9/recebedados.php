<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Recebe dados</title>
    <link rel="stylesheet" href="css.css">
</head>
<body>
    <div class="formatacao">
    <h2>Recebimento de dados</h2>
    <?php 
    echo "Seu nome: " . $_POST["nome"];
    echo "<br><br>Data de nascimento: " . $_POST["datanasc"];
    echo "<br><br>E-mail: " . $_POST["email"];

    if(isset($_POST["modelos"]))
    {
        echo"<br><br>Os modelos que você possuiu ou possui são: <br>";
        foreach($_POST["modelos"] as $modelos)
        {
            echo"- " . $modelos . "<br>";
        }
    }

    else
    {
        echo"<br><br>Você não escolheu nenhum dos modelos!";
        $modelos = null;
    }   

    echo "<br>Na sua opnião o custo benefício é: " . $_POST["linha"];

    echo "<br><br>O preço pago foi: " . $_POST["preco"];
    echo "<br><br>";
    ?>

    <input type = submit>

    </div>
    
</body>
</html>