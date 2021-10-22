<?php
    session_start();

    include 'conexao.php';

    $vDados = array();
    $cSQL = "";
    echo '{"mensagem":';
    if(!isset($_SESSION['USRCODIGO']))
    {
        mysqli_close($oCon);
        die('"Você precisa estar logado!"}');
    }
    if(!isset($_GET['txtAcao']))
    {
        mysqli_close($oCon);
        die('"Algo deu errado :("}');
    }
    else if($_GET['txtAcao'] == "1")
    {
        $cSQL = "INSERT INTO carrinho (CRRPRODUTO, CRRUSUARIO, CRRQUANTIDADE) VALUES (?, ?, ?)";
    }
    else if($_GET['txtAcao'] == "2")
    {
        $cSQL = "UPDATE carrinho SET CRRPRODUTO = ?, CRRUSUARIO = ?, CRRQUANTIDADE = ? WHERE CRRPRODUTO = " . $_GET['txtProduto'] . " AND CRRUSUARIO = " . $_SESSION['USRCODIGO'];
    }
    else if($_GET['txtAcao'] == "3")
    {
        $cSQL = "DELETE FROM carrinho WHERE CRRPRODUTO = ? AND CRRUSUARIO = ? AND CRRQUANTIDADE = ?";
    }
    else if($_GET['txtAcao'] == "4")
    {
        $cSQL = "DELETE FROM carrinho WHERE CRRUSUARIO = " . $_SESSION['USRCODIGO'];
        if(mysqli_query($oCon, $cSQL))
        {
            mysqli_close($oCon);
            die('"Seu carrinho foi deletado!"}');
        }
        else
        {
            mysqli_close($oCon);
            die('"Algo deu errado :(!"}');
        }
    }
    else 
    {
        mysqli_close($oCon);
        die('"Algo deu errado :("}');
    }
    $oCmd = mysqli_prepare($oCon, $cSQL);
    if(isset($_GET['txtProduto']) && isset($_GET['txtQuantidade']))
    {
        $oDados = mysqli_query($oCon, "SELECT 'JÁ CADASTRADO' FROM carrinho WHERE CRRPRODUTO = " . $_GET['txtProduto'] . " AND CRRUSUARIO = " . $_SESSION['USRCODIGO']);
        if($vReg = mysqli_fetch_assoc($oDados))
        {
            if($_GET['txtAcao'] == "1")
            {
                mysqli_free_result($oDados);
                mysqli_stmt_close($oCmd);
                mysqli_close($oCon);
                die('"Este produto já está no seu carrinho!"}');
            }
        }
        mysqli_free_result($oDados);
        $vDados[0] = $_GET['txtProduto'];
        $vDados[1] = $_SESSION['USRCODIGO'];
        $vDados[2] = $_GET['txtQuantidade'];
        mysqli_stmt_bind_param($oCmd, 'iii', ...$vDados);
        if(mysqli_stmt_execute($oCmd))
        {
            mysqli_stmt_close($oCmd);
            mysqli_close($oCon);
            if($_GET['txtAcao'] == "1")
                die('"O produto foi adicionado ao seu carrinho!"}');
            if($_GET['txtAcao'] == "2")
                die('"Alterado com sucesso"}');
            if($_GET['txtAcao'] == "3")
                die('"Produto apagado do carrinho"}');
        }
        else
        {
            mysqli_stmt_close($oCmd);
            mysqli_close($oCon);
            die('"Algo deu errado :("}');
        }
    }
    else if(!isset($_GET['txtProduto']))
    {
        mysqli_stmt_close($oCmd);
        mysqli_close($oCon);
        die('"Produto inválido!"}');
    }
    else if(!isset($_GET['txtQuantidade']))
    {
        mysqli_stmt_close($oCmd);
        mysqli_close($oCon);
        die('"Quantidade inválida!"}');
    }
    
    mysqli_close($oCon);
?>