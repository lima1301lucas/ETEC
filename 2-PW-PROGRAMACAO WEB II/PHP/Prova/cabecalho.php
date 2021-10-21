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
        <h1>DATA</h1>
    <?php
				$meses = array ("janeiro","fevereiro", "março", "abril","maio","junho","julho","agosto","Setembro","outubro","novembro","dezembro");
				$dia = date ("d", time());
				$mes = date ("m", time());
				$ano = date ("y", time());
                echo $dia .  " de " . $meses [$mes-1] . " de 20" . $ano;         

    ?>
    <h1>FUNÇÃO</h1>
    <?php

    function soma_valores ($valor1, $valor2, $valor3, $valor4)
				{
				  $soma = $valor1 + $valor2 * $valor3 / $valor4;
				  echo " O valor da função é $soma";
				 
				}

				$n1 = 100;
				$n2 = 300;
                $n3 = 2;
                $n4 = 400;
                soma_valores ($n1, $n2, $n3, $n4);
                ?>
    </div>
</body>
</html>