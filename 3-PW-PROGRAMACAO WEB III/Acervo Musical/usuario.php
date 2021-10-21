<?php
session_start();

$oCon = mysqli_connect('localhost', 'root', '', 'ACERVO');
$cSQL = "SELECT USRCODIGO, USRNOME" . 
" FROM USUARIOS" . 
" WHERE '" . $_POST['txtNome'] . "' IN (USRLOGIN, 
USREMAIL)" . //usuário pode escolher se quer por o usuário ou email
" AND USRSENHA = MD5('" . $_POST['txtSenha'] . "')";

$oDados = mysqli_query($oCon, $cSQL);
mysqli_error($oCon); //Para mostrar o erro caso tenha

if($vReg = mysqli_fetch_assoc($oDados))
{
    $_SESSION['USRCODIGO'] = $vReg['USRCODIGO'];
    $_SESSION['USRNOME'] = $vReg['USRNOME'];

}
else
{
    unset($_SESSION['USRCODIGO']);
    unset($_SESSION['USRNOME']);
}

mysqli_free_result($oDados);
mysqli_close($oCon);

header('location: ' . $_POST['txtPagina']);

?>