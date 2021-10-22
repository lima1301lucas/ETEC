<?php
include_once 'conexao.php';
    $cSQL = "DELETE FROM produto WHERE PRDCODIGO = " . $_POST['codigo'];
    //echo $cSQL;
    if(mysqli_query($oCon, $cSQL))
    {
        echo "Dados deletados com sucesso";
    }
    else{
        $oDados = mysqli_query($oCon, "SELECT 'COMPRADO' FROM itens WHERE ITEPRODUTO = " . $_POST['codigo']);
        if($vReg = mysqli_fetch_assoc($oDados))
        {
           echo "Este produto foi comprado, altere a visibilidade se não deseja que apareça no site";
           mysqli_free_result($oDados);
        }
        else
        {
            $oDados = mysqli_query($oCon, "SELECT 'INTERESSE' FROM carrinho WHERE CRRPRODUTO = " . $_POST['codigo']);
            if($vReg = mysqli_fetch_assoc($oDados))
            {
               echo "Alguém adicionou o produto ao carrinho, não é possível deleta-lo";
               mysqli_free_result($oDados);
            }
            else
            {
                echo "Não foi possível deletar os dados";
            }
        }
    }
    mysqli_close($oCon);
?>