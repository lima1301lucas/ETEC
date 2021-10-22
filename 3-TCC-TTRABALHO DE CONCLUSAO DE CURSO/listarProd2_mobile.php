<?php
 include_once 'conexao.php';

 $cSQL = "SELECT PRDCODIGO, PRDNOME, PRDDESCRICAO, PRDESTOQUE, PRDVENDA, 
 PRDCATEGORIA, PRDVISIVEL FROM produto";
 $oDados = mysqli_query($oCon, $cSQL);

 $json = '[';

 while($vReg = mysqli_fetch_assoc($oDados))
 {
     $json .= '{"codigo":"'. $vReg['PRDCODIGO'] . '","nome":"' . str_replace('"', '\"', $vReg['PRDNOME']). '","descricao":"' . str_replace('"', '\"', $vReg['PRDDESCRICAO']) . '","qtde":"' . $vReg['PRDESTOQUE'] . '","preco":"' . $vReg['PRDVENDA'] . '","categoria":"' . $vReg['PRDCATEGORIA'] . '","visivel":"' . $vReg['PRDVISIVEL'] . '"},';
 }

 $json .= ']';

 $json = str_replace(',]', ']', $json);
 echo $json;
?>