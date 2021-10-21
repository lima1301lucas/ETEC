<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <?php 

        include 'conexao.php';

        $sql = "INSERT INTO AVALIACAO_PARTIDOS (ID_ALUNO, AVALIACAO) VALUES ('$_GET[RM]', '$_GET[AVALIACAO]')";
        $conn->close(); 
    ?>
</body>
</html>