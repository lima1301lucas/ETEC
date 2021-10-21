<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <link rel="stylesheet" href="css/partido.css" class="css">
    <title>CADASTRO DOS PARTIDOS</title>
</head>

<body>
    <div class="geral">
        <div class="titulo">
            <img src="img/flag.svg" class="icone">
            <h1 class="subtitulo">CADASTRO DE PARTIDOS</h1>
        </div>
        <section class="box-partido">
            <div class="container">
                <div>
                    <form method="POST" enctype="multipart/form-data" accept-charset="UTF-8" autocomplete="off">
                        <div class="nome">
                            <label>NOME DO PARTIDO:
                                <input type="text" name="nome" class="inp-nome" autocomplete="off">
                            </label>
                        </div>
                        <div class="imagem">
                            <label>IMAGEM PARA O PARTIDO:
                                <input type="file" class="inp-img" name="arquivo"
                                    accept="image/png, image/jpeg, image/jpg">
                            </label>
                        </div>
                        <div class="descricao">
                            <label class="desc">DESCRIÇÃO DO PARTIDO:</label>
                            <div class="texto">
                                <textarea name="descricao" id="texto" maxlength="400"></textarea>
                            </div>
                            <div class="aviso" id="falta">

                            </div>
                        </div>
                        <button type="submit" class="botao">CADASTRAR</button>
                    </form>
                </div>
            </div>
        </section>
    </div>
</body>

</html>

<script type="text/javascript">
    function contarTexto(campo, limite, container) {
 if (campo.value.length > limite) {
 campo.value = campo.value.substring(0, limite);
 } else {
 d = document.getElementById(container);
 d.innerHTML = 'Restam ' + (parseInt(limite) - parseInt(campo.value.length) + ' caracteres');
 }
}
document.getElementById("texto").addEventListener("keydown", function(){
 contarTexto(this, 400, "falta");
});
</script>

<?php 

if(isset($_FILES['arquivo'])){
    $extensao = strtolower(substr($_FILES['arquivo']['name'], -4));
    $novo_nome = md5(time()).$extensao;
    $diretorio = "upload/";
    move_uploaded_file($_FILES['arquivo']['tmp_name'],$diretorio.$novo_nome);

    include 'conexao.php';

    $nome = $_POST['nome'];
    $descricao = $_POST['descricao'];
    
    
    $sql = "INSERT INTO PARTIDOS (NOME, FOTO, DESCRICAO) VALUES ('$nome','$novo_nome','$descricao')";
    
    if ($conn->query($sql) === TRUE) {
        echo  "<script>alert('Dados do partido cadastrado com sucesso!');</script>";
    } 
    else {
        echo "Erro: " . $sql . "<br>" . $conn->error;
    }
    $conn->close(); 
}
?>