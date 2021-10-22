<?php

    include 'conexao.php';

    $user = $_GET['user'];
    $cpf = $_GET['cpf'];
    $email = $_GET['email'];

    $sql = "SELECT 'ENCONTRADO' FROM usuario WHERE '$user' = USRUSUARIO LIMIT 1";
    //echo $sql;
    $result = mysqli_query($oCon, $sql);
    echo '{"usuario":"';
    if($resultado = mysqli_fetch_assoc($result))
    {
        echo $resultado['ENCONTRADO'];
    }
    else
        echo "NÃO ENCONTRADO";

    echo '", "cpf":"';

    $sql = "SELECT 'ENCONTRADO' FROM usuario WHERE '$cpf' = USRCPF LIMIT 1";
    //echo $sql;
    $result = mysqli_query($oCon, $sql);

    if($resultado = mysqli_fetch_assoc($result))
    {
        echo $resultado['ENCONTRADO'];
    }
    else
        echo "NÃO ENCONTRADO";
    echo '", "email":"';

    $sql = "SELECT 'ENCONTRADO' FROM usuario WHERE '$email' = USREMAIL LIMIT 1";
    //echo $sql;
    $result = mysqli_query($oCon, $sql);

    if($resultado = mysqli_fetch_assoc($result))
    {
        echo $resultado['ENCONTRADO'];
    }
    else
        echo "NÃO ENCONTRADO";
    echo '"}';
    
    mysqli_free_result($result);
    mysqli_close($oCon);

?>