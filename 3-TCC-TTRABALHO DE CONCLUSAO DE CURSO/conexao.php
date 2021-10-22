<?php 
    $server = "31.170.166.145"; 
    $database = "u699901023_loja_pigmeu";
    $user = "u699901023_user_pigmeu"; 
    $pwd = "SenhatccPIGMEU2020"; 

    $oCon = mysqli_connect($server, $user, $pwd, $database);
    $oCon->set_charset("utf8");

    if(!$oCon)
    {
        die("Connection failed: " . mysqli_connect_error());
    }
?>