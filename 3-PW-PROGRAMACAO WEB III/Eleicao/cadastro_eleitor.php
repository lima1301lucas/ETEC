<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <link rel="stylesheet" href="css/eleitor.css" class="css">
    <title>CADASTRO DE ELEITORES</title>
</head>

<body>
    <div class="geral">
        <div class="titulo">
            <img src="img/users.svg " class="icone">
            <h1 class="subtitulo">CADASTRO DE ELEITORES</h1>
        </div>
        <section class="box-eleitor">
            <div class="container">
                <div class="form-eleitor">
                    <form method="POST" accept-charset="UTF-8" autocomplete="off">
                        <div class="nome">
                            <label>NOME:</label>
                            <input type="text" class="inp-nome" name="nome" autocomplete="off">
                        </div>
                        <div class="dados">
                            <div class="rm">
                                <label>RM:
                                    <input type="text" class="inp-rm" name="rm" maxlength="5" autocomplete="off">
                                </label>
                            </div>
                            <div class="rg">
                                <label>RG:
                                    <input type="text" class="inp-rg" name="rg" maxlength="12" autocomplete="off">
                                </label>
                            </div>
                        </div>
                        <div class="data">
                            <label>DATA DE NASCIMENTO:
                                <input type="date" class="inp-data" name="nascimento" autocomplete="off">
                            </label>
                        </div>
                        <button type="submit">CADASTRAR</button>
                    </form>
                </div>
            </div>
        </section>
    </div>
</body>


</html>

<?php 

if(isset($_POST['nome'])){
include 'conexao.php';

$rm = $_POST['rm'];
$rg	= $_POST['rg'];
$nome = $_POST['nome'];
$datanasc = $_POST['nascimento'];


$sql = "INSERT INTO ALUNOS (RM, RG, NOME, DTNASC) VALUES ('$rm','$rg','$nome', '$datanasc')";

if ($conn->query($sql) === TRUE) {
    echo  "<script>alert('Dados do eleitor cadastrados com sucesso!');</script>";
} 
else {
	echo "Erro: " . $sql . "<br>" . $conn->error;
}
$conn->close(); 
}

?>