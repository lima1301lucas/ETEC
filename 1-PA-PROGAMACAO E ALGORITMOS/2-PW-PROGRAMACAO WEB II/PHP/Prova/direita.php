<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css/style.css">
    <title>Cabeçalho</title>
</head>
<body>
    <div class="formatacao">

    <h1>DO WHILE</h1>
    <?php
    $cont = 1;
    while ($cont<12){

    echo "o valor atual do contatdor é $cont <br>";
    $cont++;
    }?>
    


    <h1>FUNÇÃO ESCOPO</h1>
    <?php
         $num = 1;
          
          function testa_escopo ( ) 
          {
		    global $num;               
 		    $num += 1;
            echo $num .  "<br>";
          }



        echo $num . "<br>";
        testa_escopo ( );
        ?>


<h1>CONSTANTES</h1>
<?php
                        define ("meunome","Lucas");
						define ("data","13/01/2003");
						echo "Meu nome é " .meunome;
						echo "<br>";
						echo "O meu aniversário é " .data;
     

    ?>
    </div>
    </div>
</body>
</html>