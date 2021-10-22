<?php
    /*$oCon = mysqli_connect("localhost", "root", "", "loja_pigmeu");
    $cSQL = "SELECT CTGCODIGO, CTGNOME FROM CATEGORIA";
    $oDados = mysqli_query($oCon, $cSQL);
    $json = '{';
    while($vReg = mysqli_fetch_assoc($oDados))
    {
        $json .= '"' . $vReg['CTGCODIGO'] . '":"' . $vReg['CTGNOME'] . '",';
    }
    $json .= '}';
    $json = str_replace(',}', '}', $json);
    echo $json;*/
    include_once 'conexao.php';

    $cSQL = "SELECT PRDCODIGO, PRDNOME, PRDDESCRICAO, PRDESTOQUE, PRDVENDA, 
    CTGNOME, PRDVISIVEL FROM produto INNER JOIN categoria ON CTGCODIGO = PRDCATEGORIA";
    $oDados = mysqli_query($oCon, $cSQL);

    $json = '[';

    while($vReg = mysqli_fetch_assoc($oDados))
    {
        $json .= '{"codigo":"'. $vReg['PRDCODIGO'] . '","nome":"' . $vReg['PRDNOME']. '","descricao":"' . $vReg['PRDDESCRICAO'] . '","qtde":"' . $vReg['PRDESTOQUE'] . '","preco":"' . $vReg['PRDVENDA'] . '","categoria":"' . $vReg['CTGNOME'] . '","visivel":"' . str_replace('0', 'Não', str_replace('1', 'Sim', $vReg['PRDVISIVEL'])) . '"},';
    }

    $json .= ']';

    $json = str_replace(',]', ']', $json);
    echo $json;
?>