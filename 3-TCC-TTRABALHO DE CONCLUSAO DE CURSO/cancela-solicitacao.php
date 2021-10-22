<?php

include 'conexao.php';

if(isset($_GET['nCod']))
{
    $cSQL = "UPDATE usuario SET USRDTMAX = NOW() WHERE MD5(USRCODIGO) = '" . $_GET['nCod'] . "'";
    if(mysqli_query($oCon, $cSQL))
    {
        echo "<script>alert('Sua solicitação para alterar senha foi cancelada, obrigado por avisar!');window.location.href='index.php';</script>";
    }
    else
    {
        echo "<script>alert('Ocorreu um erro!');window.location.href='index.php';</script>";
        echo mysqli_error($oCon) . "<br>";
        mysqli_close($oCon);
        die($cSQL);
    }
}
else
{
    echo "<script>alert('Você não tem autorização para acessar essa página!');window.location.href='index.php';</script>";
    mysqli_close($oCon);
    die();
}

mysqli_close($oCon);

?>