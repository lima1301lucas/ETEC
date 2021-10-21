<!DOCTYPE html>
<html lang="PT-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Conexão</title>
</head>
<body>
    <?php 
    $server = "localhost"; 
    $database = "acervo";
    $user = "root"; 
    $pwd = ""; 

    $oCon = mysqli_connect($server, $user, $pwd, $database);
    $oCon->set_charset("utf8");

    if(!$oCon)
    {
        die("Connection failed: " . mysqli_connect_error());
    }
    ?>
</body>
</html>