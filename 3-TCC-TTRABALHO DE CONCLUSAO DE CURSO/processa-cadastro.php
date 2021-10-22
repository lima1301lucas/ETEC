<?php 
    session_start();

    include 'conexao.php';
    
    $usuario = $_POST['txtUsuario'];
    $email = $_POST['txtEmail'];
    $senha = $_POST['txtSenha'];
    $senha = MD5($senha);
    $cpf = $_POST['txtCPF'];
    $nome = $_POST['txtNome'];
     
    mysqli_begin_transaction($oCon);

    $cSQL = "INSERT INTO usuario (USRUSUARIO, USREMAIL, USRSENHA, USRCPF, USRNOME) VALUES ('$usuario', '$email', '$senha', '$cpf', '$nome')"; 
    
    if(mysqli_query($oCon, $cSQL))
    {
        $id_usuario = mysqli_insert_id($oCon);
        $telefone = $_POST['txtTelefone'];
        $celular = $_POST['txtCelular'];

        $cSQL = "INSERT INTO telefone (TFNUSUARIO, TFNCELULAR) VALUES ('$id_usuario', '$telefone'), ('$id_usuario', '$celular') ";

        if(mysqli_query($oCon, $cSQL))
        {
            $cep = $_POST['txtCep'];
            $bairro = $_POST['txtBairro'];
            $estado = $_POST['slcEstado'];
            $cidade = $_POST['txtCidade'];
            $endereco = $_POST['txtEndereco'];
            $numero = $_POST['txtNumero'];
            $complemento = $_POST['txtComplemento'];

            $cSQL = "INSERT INTO endereco (ENDCEP, ENDBAIRRO, ENDESTADO, ENDCIDADE, ENDLOGRADOURO, ENDNUMERO, ENDCOMPL, ENDUSUARIO) VALUES ('$cep', '$bairro', '$estado', '$cidade', '$endereco', '$numero', '$complemento', '$id_usuario')";

            if(mysqli_query($oCon, $cSQL))
            {
                mysqli_commit($oCon);
                $_SESSION['USRCODIGO'] = $id_usuario;
                $_SESSION['USRNOME'] = $nome;
                echo "<script>alert('Cadastro realizado com sucesso!');window.location.href = 'index.php';</script>";
            }
            else
            {
                echo 'erro no endereco';
                echo mysqli_error($oCon); 
                mysqli_rollback($oCon);
            }
        }
        else
        {
            echo 'erro no tel';
            echo mysqli_error($oCon); 
            mysqli_rollback($oCon);
        }
    }
    else
    {
        if(mysqli_error($oCon) == "Duplicate entry '". $usuario ."' for key 'USRUSUARIO'")
        {
            mysqli_rollback($oCon);
            echo "<script>alert('Este usuário já está cadastrado!');window.location.href = 'cadastro.php';</script>";
        }
        else if (mysqli_error($oCon) == "Duplicate entry '". $email ."' for key 'USREMAIL'")
        {
            mysqli_rollback($oCon);
            echo "<script>alert('Este email já está cadastrado!');window.location.href = 'cadastro.php';</script>";
        }
        else if (mysqli_error($oCon) == "Duplicate entry '". $cpf ."' for key 'USRCPF'")
        {
            mysqli_rollback($oCon);
            echo "<script>alert('Este CPF já está cadastrado!');window.location.href = 'cadastro.php';</script>";
        }
        else
        {
            echo 'erro no user ' . mysqli_error($oCon); 
            mysqli_rollback($oCon);
        }
    }

    mysqli_close($oCon);
?>