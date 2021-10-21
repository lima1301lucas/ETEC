<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
<h1>Recebendo dados do formulário radio</h1>

    <?php 
   
        echo"Seu SO é : " .$_POST["sistema"];
        echo"Seu Monitor é : " .$_POST["monitor"];
       
       ?>
</body>
</html>