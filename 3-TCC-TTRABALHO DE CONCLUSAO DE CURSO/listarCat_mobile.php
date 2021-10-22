<?php
    include_once 'conexao.php';
    
    $cSQL = "SELECT CTGCODIGO, CTGNOME FROM categoria";
    $oDados = mysqli_query($oCon, $cSQL);
    $json = '{';
    while($vReg = mysqli_fetch_assoc($oDados))
    {
        $json .= '"' . $vReg['CTGCODIGO'] . '":"' . $vReg['CTGNOME'] . '",';
    }
    $json .= '}';
    $json = str_replace(',}', '}', $json);
    echo $json;
?>
