<?php 

    session_start();
    include 'conexao.php';

    $rm = $_POST['rm'];
    $_SESSION['funcione'] = $rm;
    $rg = $_POST['rg'];


    if((isset($_POST['rm'])) && (isset($_POST['rg'])))
    {
        if(($rm == "Admin") && ($rg == "Admin"))
        {
            $_SESSION['LoginErro'] = "Administrador";
            header("Location: apuracao.php");
        }

        else
        {
            $sql = "SELECT RM, RG FROM ALUNOS WHERE RM = '$rm' && RG = '$rg' LIMIT 1";
            $result = mysqli_query($conn, $sql);
            $resultado = mysqli_fetch_assoc($result);

            if(empty($resultado))
            {
                $_SESSION['LoginErro'] = "RM ou RG não cadastrados";
                header("Location: index.php");
            }

            elseif(isset($resultado))
            {
                header("Location: votacao.php");
            }

            else
            {
                $_SESSION['LoginErro'] = "RM ou RG não cadastrados";
                header("Location: index.php");
            }
        }
    }

    else{
        $_SESSION['LoginErro'] = "RM ou RG não cadastrados";
        header("Location: index.php");
    }
?>