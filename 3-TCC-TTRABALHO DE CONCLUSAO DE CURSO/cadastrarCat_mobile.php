<?php
include_once 'conexao.php';

$nomeCat = addslashes($_POST['CTGNOME']);

$sql = $oCon->query("SELECT * FROM categoria;");

if ($sql)
{
    $sql1 = $oCon->query("INSERT INTO categoria(CTGNOME) VALUES ('$nomeCat');");
         
         if($sql1)
         echo "registro efetuado";
         else
         echo "Não foi possivel efetuar o insert";
}

?>