<?php
include_once 'conexao.php';
    $cSQL = "UPDATE produto SET PRDNOME = '" . $_POST['produto'] . "', PRDDESCRICAO = '" . $_POST['descricao'] . "', PRDESTOQUE = '" . $_POST['estoque'] . "', PRDVENDA = '" . $_POST['venda'] . "', PRDCATEGORIA = '" . $_POST['categoria'] . "', PRDVISIVEL = '" . $_POST['visivel'] . "'  WHERE PRDCODIGO = " . $_POST['codigo'];
    //echo $cSQL;
    if(mysqli_query($oCon, $cSQL))
    {
        echo "Dados atualizados com sucesso";
    }
    else{
        //echo "Não foi possível atualizar os dados";
        echo mysqli_error($oCon);
    }
?>