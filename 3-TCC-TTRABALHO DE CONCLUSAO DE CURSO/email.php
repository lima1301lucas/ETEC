<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/senha.css">
    <title>Troca de senha</title>
</head>
<?php

ini_set('display_errors', 1);

error_reporting(E_ALL);

include 'conexao.php';

$nome = "";
$codigo = "";

mysqli_begin_transaction($oCon);

$cSQL = "SELECT MD5(USRCODIGO) 'USRCODIGO', USRNOME, USREMAIL FROM usuario WHERE USREMAIL = '" . $_POST['txtEmail'] . "'";

$oDados = mysqli_query($oCon, $cSQL);

if($vReg = mysqli_fetch_assoc($oDados))
{
    $nome = str_replace('"', '\"', str_replace("'", "\'", $vReg['USRNOME']));
    $codigo = $vReg['USRCODIGO'];
    mysqli_free_result($oDados);
}
else
{
    mysqli_free_result($oDados);
    mysqli_rollback($oCon);
    mysqli_close($oCon);
    die($cSQL);
}

/*
TRABALHAR COM DATETIME NO PHP É UM SACO RS

$date = new DateTime(date("Y-m-d H:i:s"));
date_timezone_set($date, new DateTimeZone("America/Sao_Paulo"));
$date->add(new DateInterval('PT1H30S'));
var_dump($date);

$cSQL = "UPDATE usuario SET USRDTMAX = '" . $date->format('Y-m-d H:i:s') . "' WHERE USRCODIGO = $codigo";*/

$cSQL = "UPDATE usuario SET USRDTMAX = DATE_ADD(NOW(), INTERVAL 1 HOUR) WHERE MD5(USRCODIGO) = '" . $codigo . "'";
//echo $codigo;
//echo $_POST['txtEmail'];
if(mysqli_query($oCon, $cSQL))
{
    $from = "suportetecnicopigmeu@tccpigmeu.tk";

    $to = $_POST['txtEmail'];

    $subject = "Solicitação para alterar senha pigmeu";

    $message = "Olá, " . $nome . "!<br><br><br>Recebemos uma solicitação para trocar sua senha no e-commerce pigmeu!";
    $message .= "Aqui está o link para a alteração de senha: <br><br>https://tccpigmeu.tk/esqueci-senha.php?nCod=" . $codigo ;
    $message .= "<br><br>O link acima é valido por uma hora a partir do momento do envio, se precisar trocar sua senha posteriormente recomendamos que cancele a solicitação e solicite um novo link mais tarde.";
    $message .= "<br><br>Se não foi você que solicitou a troca, alguém pode estar tentando roubar sua senha,";
    $message .= " recomendamos que cancele agora mesmo a solicitação, clique aqui para cancelar: ";
    $message .= "https://tccpigmeu.tk/cancela-solicitacao.php?nCod=" . $codigo;
    $message .= "<br><br>Obrigado, pela atenção! Compre sempre na e-commerce pigmeu!";

    $headers = 'Content-type: text/html; charset=utf-8' . "\r\n";
    $headers .= 'From: ' . $from;

    if(mail($to, $subject, $message, $headers))
    {

    }
    else
    {
        //mysqli_rollback($oCon);
        //mysqli_close($oCon);
        //die('Não foi possível enviar o e-mail');
    }
}
else
{
    mysqli_free_result($oDados);
    mysqli_rollback($oCon);
    mysqli_close($oCon);
    die($cSQL);
}


mysqli_commit($oCon);
mysqli_close($oCon);
echo "<script>
alert('Enviamos um link no seu email para poder trocar sua senha! Verifique a caixa de entrada, spam e lixo eletrônico!');window.location.href='index.php';</script>";

?>