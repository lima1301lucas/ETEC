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
    $server = "192.168.0.8"; /*localhost*/
    $database = "BD_ELEICAO";
    $user = "Aluno3DS"; /*root*/
    $pwd = "SenhaBD3"; 

    $conn = mysqli_connect($server, $user, $pwd, $database);
    $conn->set_charset("utf8");

    if(!$conn)
    {
        die("Connection failed: " . mysqli_connect_error());
    }
    ?>
</body>
</html>