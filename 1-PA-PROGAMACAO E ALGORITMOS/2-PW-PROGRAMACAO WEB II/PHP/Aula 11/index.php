<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 11 - Conectando com MySQL</title>
</head>
<body>
    <?php 
        //iniciando a conexão com o banco de dados
        $cx = mysqli_connect("localhost:3306", "root", "1234");

        //selecionando o banco de dados
        $db = mysqli_select_db($cx, "php_5");

        //criando a query de consulta à tabela criada
        $sql = mysqli_query($cx, "select * from usuario") or die (mysqli_error($cx));//se tiver erro na consulta

        //percorrendo os registros da consulta
        while($aux = mysqli_fetch_assoc($sql)){
            echo "VAMOS EXIBIR OS DADOS DA TABELA USUÁRIO DO BANCO DE DADOS <br />";
            echo "Login: ".$aux["login"]."<br />";
            echo "Senha: ".$aux["senha"]."<br />";
        }

    ?>
    </body>
</html>