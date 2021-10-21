<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css.css" class="css">
    <title>Index</title>
</head>
<body>

    <p>Cadastre-se</p>
    <form method="POST" action="cadastro_formulario.php">
        <label>Nome: </label>
        <input type="text" name="login" id="login"><br>

        <label>E-mail: </label>
        <input type="text" name="email" id="email"><br>

        <label>Cidade: </label>
        <input type="text" name="cidade" id="cidade"><br>

        <label>Estado: </label>
        <input type="text" name="estado" id="estado"><br>

        <label>Comentarios: </label>
        <input type="text" name="comentarios" id="comentarios"><br>

        <label>Senha: </label>
        <input type="password" name="senha" id="senha"><br>

        <input class="button" type="submit" value="Cadastrar" name="cadastrar" id="cadastrar">

    </form>
    
</body>
</html>