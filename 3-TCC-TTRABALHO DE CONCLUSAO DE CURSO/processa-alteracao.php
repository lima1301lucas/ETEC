<?php
    session_start();

    include 'conexao.php';
    $vDados = array();
    $cTipos = '';
    mysqli_begin_transaction($oCon);

    if($_POST['txtTroca'] == 's')
    {
        $oDados = mysqli_query($oCon, "SELECT 'OK' FROM usuario WHERE USRCODIGO = " . $_SESSION['USRCODIGO'] . " AND USRSENHA = MD5('" . $_POST['txtSenhaAntiga'] . "')");
        if($vReg = mysqli_fetch_assoc($oDados))
        {
            $cSQL = "UPDATE usuario SET USRUSUARIO = ? , USREMAIL = ? , USRSENHA = md5(?) , USRCPF = ? , USRNOME = ?  WHERE USRCODIGO = " . $_SESSION['USRCODIGO'];
            $vDados[0] = $_POST['txtUsuario'];
            $vDados[1] = $_POST['txtEmail'];
            $vDados[2] = $_POST['txtSenha'];
            $vDados[3] = $_POST['txtCPF'];
            $vDados[4] = $_POST['txtNome'];
            $cTipos = 'sssss';
        }
        else
        {
            die("<script>alert('A senha está incorreta, não foi feita nenhuma alteração!');window.location.href='alterar.php';</script>");
        }
    }
    else
    {
        $cSQL = "UPDATE usuario SET USRUSUARIO = ? , USREMAIL = ? , USRCPF = ? , USRNOME = ?  WHERE USRCODIGO = ?";
        $vDados[0] = $_POST['txtUsuario'];
        $vDados[1] = $_POST['txtEmail'];
        $vDados[2] = $_POST['txtCPF'];
        $vDados[3] = $_POST['txtNome'];
        $vDados[4] = $_SESSION['USRCODIGO'];
        $cTipos = 'ssssi';
    }

    $oCmd = mysqli_prepare($oCon, $cSQL);

    mysqli_stmt_bind_param($oCmd, $cTipos, ...$vDados);
    if(mysqli_stmt_execute($oCmd))
    {
        mysqli_stmt_close($oCmd);
    }
    else{
        mysqli_stmt_close($oCmd);
        mysqli_rollback($oCon);
        echo mysqli_error($oCon);
        mysqli_close($oCon);
        die("<script>alert('Ocorreu um erro na alteração, tente novamente mais tarde.');window.location.href='alterar.php';</script>");
    }

    $vDados = array();
    $cSQL = "UPDATE telefone SET TFNCELULAR = ? WHERE TFNCELULAR = ? AND TFNUSUARIO = ?";
    $oCmd = mysqli_prepare($oCon, $cSQL);

    $i = 0;

    $oDados = mysqli_query($oCon, 'SELECT * FROM telefone WHERE TFNUSUARIO = ' . $_SESSION['USRCODIGO']);
    while($vReg = mysqli_fetch_assoc($oDados))
    {
        $vDados[0] = ($i == 0)?$_POST['txtTelefone']:$_POST['txtCelular'];
        $vDados[1] = $vReg['TFNCELULAR'];
        $vDados[2] = $_SESSION['USRCODIGO'];

        mysqli_stmt_bind_param($oCmd, 'ssi', ...$vDados);
        if(!mysqli_stmt_execute($oCmd))
        {
            mysqli_stmt_close($oCmd);
            mysqli_rollback($oCon);
            echo mysqli_error($oCon);
            mysqli_close($oCon);
            die("<script>alert('Ocorreu um erro na alteração, tente novamente mais tarde.');window.location.href='alterar.php';</script>");
        }

        $i++;
    }
    mysqli_stmt_close($oCmd);
    mysqli_free_result($oDados);

    $vDados = array();

    $oEndereco = mysqli_query($oCon, "SELECT 'EXISTE' FROM endereco WHERE ENDCEP = '" . $_POST['txtCep'] . "' AND ENDNUMERO = '" . $_POST['txtNumero'] . "' AND ENDCOMPL = '" . $_POST['txtComplemento'] . "' AND ENDUSUARIO = " . $_SESSION['USRCODIGO']);

    if(!$vEnd = mysqli_fetch_assoc($oEndereco))
    {
        $cSQL = "INSERT INTO endereco (ENDCEP, ENDBAIRRO, ENDESTADO, ENDCIDADE, ENDLOGRADOURO, ENDNUMERO, ENDCOMPL, ENDUSUARIO) VALUES(?, ?, ?, ?, ?, ?, ?, " . $_SESSION['USRCODIGO'] . ")";
    }
    else{
        $cSQL = "UPDATE endereco SET ENDCEP = ? , ENDBAIRRO = ? , ENDESTADO = ? , ENDCIDADE = ? , ENDLOGRADOURO = ? , ENDNUMERO = ? , ENDCOMPL = ? WHERE ENDUSUARIO = " . $_SESSION['USRCODIGO'];
    }
    mysqli_free_result($oEndereco);
    
    $vDados[0] = $_POST['txtCep'];
    $vDados[1] = $_POST['txtBairro'];
    $vDados[2] = $_POST['slcEstado'];
    $vDados[3] = $_POST['txtCidade'];
    $vDados[4] = $_POST['txtEndereco'];
    $vDados[5] = $_POST['txtNumero'];
    $vDados[6] = $_POST['txtComplemento'];

    $oCmd = mysqli_prepare($oCon, $cSQL);

    mysqli_stmt_bind_param($oCmd, 'sssssss', ...$vDados);
    if(mysqli_stmt_execute($oCmd))
    {
        mysqli_stmt_close($oCmd);
    }
    else{
        mysqli_stmt_close($oCmd);
        mysqli_rollback($oCon);
        echo mysqli_error($oCon);
        mysqli_close($oCon);
        die("<script>alert('Ocorreu um erro na alteração, tente novamente mais tarde.');window.location.href='alterar.php';</script>");
    }

    echo "<script>alert('Dados alterados com sucesso!');window.location.href='index.php';</script>";

    mysqli_commit($oCon);
    myqli_close($oCon);
?>