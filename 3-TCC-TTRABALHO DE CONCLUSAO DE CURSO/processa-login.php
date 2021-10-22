<?php
    
    session_start();

    include_once("conexao.php");

    $login = mysqli_real_escape_string($oCon, $_POST['txtNome']);
    $senha = mysqli_real_escape_string($oCon, $_POST['txtSenha']);
        
    echo $login . "<br>";
    echo $senha . "<br>";

    if((!empty($login)) && (!empty($senha)))
    {
        $sql = "SELECT USRCODIGO, USRNOME FROM usuario WHERE '$login' IN (USREMAIL, USRUSUARIO) AND USRSENHA = MD5('$senha') LIMIT 1";
        echo $sql;
        $result = mysqli_query($oCon, $sql);
    
        if($resultado = mysqli_fetch_assoc($result))
        {
            $_SESSION['USRCODIGO'] = $resultado['USRCODIGO'];
            $_SESSION['USRNOME'] = $resultado['USRNOME'];
            unset($_SESSION['UDEUBOSTA']);
            header('location: index.php');
        }
        else
        {
            unset($_SESSION['USRCODIGO']);
            unset($_SESSION['USRNOME']);
            $_SESSION['DEUBOSTA'] = true;
            header('location: login.php');
            echo mysqli_error($oCon);
        }
    }
    else
    {
        echo mysqli_error($oCon);
    }

    mysqli_free_result($result);
    mysqli_close($oCon);
?>