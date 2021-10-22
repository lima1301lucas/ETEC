<?php
include_once 'conexao.php';

$nome = addslashes($_POST['PRDNOME']);
$descricao = addslashes($_POST['PRDDESCRICAO']);
$estoque = $_POST['PRDESTOQUE'];
$venda = $_POST['PRDVENDA'];
$categoria = addslashes($_POST['PRDCATEGORIA']);
$visivel = $_POST['PRDVISIVEL'];

    $sql1 = $oCon->query("INSERT INTO produto(PRDNOME, PRDDESCRICAO, PRDESTOQUE, PRDVENDA, 
    PRDCATEGORIA, PRDVISIVEL) VALUES ('$nome', '$descricao', '$estoque', '$venda', '$categoria', '$visivel');");
         
         if($sql1)
         {
         echo "registro efetuado\n";
         echo mysqli_insert_id($oCon);
         }
         else
         echo "Não foi possivel efetuar o insert";
?>