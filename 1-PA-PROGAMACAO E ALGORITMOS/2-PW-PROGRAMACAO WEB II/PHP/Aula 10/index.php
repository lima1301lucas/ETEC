<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css.css" class="css">
    <title>Primeira etapa</title>
</head>
<body>
    <h2>Primeira etapa</h2>

    <div class="form">

        <form action="index2.php" method="POST">

        <div class="form">
        Nome: <input type="text" name="nome" size="20">
        </div>

        <div class="form">
        E-mail: <input type="text" name="email" size="30">
        </div>

        <div class="form">
        Data de nascimento: <input type="date" name="datanascimento">
        </div>

        <div class="form">
        Sexo: <input type="radio" value="masculino" checked name ="sexo">Masculino &nbsp;&nbsp;
              <input type="radio" value="feminino" name ="sexo">Feminino
        </div>

        <div class="form">
        Profissão: <input type="text" name="profissao" size="20">
        </div>

        <input type="submit" value="Prosseguir &gt;&gt;">
        </div>

        </form>
    </div>
</body>
</html>
