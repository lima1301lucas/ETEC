<?php
include_once 'conexao.php';

    $cSQL = "SELECT GSTNOME, GSTVALOR, DATE(GSTDATA) 'DATA' FROM gastos WHERE GSTCODIGO = " . $_GET['nCod'];
    $oDados = mysqli_query($oCon, $cSQL);

    $json = '{';

    while($vReg = mysqli_fetch_assoc($oDados))
    {
        $json .= '"nome":"'. str_replace('"', '\"', $vReg['GSTNOME']) . '","valor":"' . $vReg['GSTVALOR']. '","data":"' . $vReg['DATA'] . '"';
    }

    $json .= '}';

    //$json = str_replace(',}', '}', $json);
    echo $json;
?>