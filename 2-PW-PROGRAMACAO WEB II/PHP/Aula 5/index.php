<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel ="stylesheet" href = "css.css">
    <title>Document</title>
</head>
<body>
    <div class="CLASSE">
    <h1>OPERADORES ARITIMÉTICOS</h1>

    <?php 

    $soma=0;
    $valor1 = 10;
    $valor2 = 20;
    $valor3 = 30;

    $soma = $valor1 * $valor3 / $valor2;

    echo "$soma<br>";
    echo "$valor1<br>";
    echo "$valor2<br>";
    echo "$valor3<br>";

     
    ?>

    <h1>IF E ELSE</h1>
    <?php 

        $prova1 = 10;
        $prova2 = 10;

        $nota = ($prova1 + $prova2) / 2;

        if($nota < 3)
            $desempenho = "PÉSSIMO";
        else if($nota < 5){
            $desempenho = "RUIM";
            }
        else if($nota < 7){
            $desempenho = "MÉDIO";
            }
         else if($nota < 9){
            $desempenho = "BOM";
            }
         else{
            $desempenho = "ÓTIMO";
            }
        
        echo"O SEU DESEMPENHO FOI $desempenho";
    ?>

        <h1>ELSE E IF</h1>
        <?php 

        $A = 5;
        $B = 6;

        if( $A > $B){
            echo "A variável a é maior que b";
        }

        else if( $A = $B){
            echo "A variável a é igual a b";
        }
        else{
            echo "A variável a é menor a b";
        }
        ?>

        <h1>WHILE</h1>
        <?php 
        $cont = 0;
        while($cont<=100)
        {
            echo "o valor do contador é $cont <br>";
            $cont++;
        }
        ?>

        <h1>SWITCH</h1>
        <?php
        $numero = 1;
        switch ($numero){
            
            case 0:
            echo "número vale 0";
            break;

            case 1:
            echo "número vale 1";
            break;

            case 2:
            echo "número vale 2";
            break;
        }
        ?>

        <h1>DO WHILE</h1>
        <?php
        $numero = 1;
        
        do{
        echo "O valor atual de número é $numero <br>";
        $numero++;
        } 
        while($numero <= 4);
        ?>


    </div>
</body>
</html>