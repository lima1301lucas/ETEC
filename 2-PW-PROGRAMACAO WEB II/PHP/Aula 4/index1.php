<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 4</title>
    <link rel="stylesheet" href="css.css">
</head>
<body>
    <h1 align = "center"><strong>Conversão de variáveis</strong></h1>
    <?php 
        $x = 50;
        $y = 2.35;
        $soma = (int)$x + $y;
        echo "<p>Soma = $soma<p>";
    ?>

    <h1 align = "center"><strong>Interpolação de variáveis</strong></h1>
    <?php 
        $time = "Barcelona";
        $titulo = "Campeão";
        $ano1 = "2017";
        $ano2 = "2018";
        echo "<p> O $time foi  $titulo em $ano1 e $ano2</p>";
    ?>

    <h1 align = "center"><strong>Variáveis numéricas</strong></h1>
    <?php 
        $numero = 10;
        $x = 5;
        $numero_hexa = 0x0b; //valor hexadecimal
        $z = 15.002;
        $a = 200.3;
        echo "<p>$numero - $x - $numero_hexa - $z - $a</p>";
    ?>

    <h1 align = "center"><strong>Vetor</strong></h1>
    <?php 
        $vetor = array (10,50,100,150,200);
        echo "<p>$vetor[3] . <br></p>";
        $vet = array (1,2,3, "nome" => "Joaquim");
        echo "<p>$vet[1]  <br></p>";
        echo "<p>$vet[nome] . </p>";
    ?>

    
    <h1 align = "center"><strong>Classe</strong></h1>
    <?php 
       class teste{
           function saudacao(){
               echo "<p> Oi alunos</p>";

           }
       }

       $objeto = new teste;
       $objeto -> saudacao();
    ?>


</body>
</html>