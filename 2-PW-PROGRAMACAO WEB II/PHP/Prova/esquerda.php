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
		<H1>CONCATENAÇÃO</H1>
    <?php
    $var1 = "Bom ";
    $var2 = "dia!!";

	echo "$var1 $var2";
	?>

	<H1>FUNÇÃO RECURSIVA</H1>
	<?php

	function prova ($valor)
{
	if ($valor!=0)
	{
		echo "foi chamada a função passando valor $valor até chegar em 1 <br>";
		prova ($valor-1);
	}
	}
	prova (10);
    
	?>

<H1>CLASSE SAUDAÇÃO</H1>
<?php

            
            class Teste
						{

							function Saudacao(){
                            echo "Sou aluno da Etec Jaraguá<br>";	
							}

						}


						$objeto = new Teste;
                        $objeto -> Saudacao(); ?>
						
						
						<H1>IF - ELSE</H1>
<?php
                        $prova1 = 7;
						$prova2 = 5;
						$nota = ($prova1 + $prova2) / 2;

						if ($nota<3)
							$desempenho = "RUIM";

						elseif ($nota<5) {
							$desempenho = "REGULAR";
							}

						elseif ($nota<7) {
							$desempenho = "BOM";
							}
						elseif ($nota=10) {
							$desempenho = "ÓTIMO";
								
							}	

							echo "o seu desempenho foi $desempenho"; 
	?>
    </div>
</body>
</html>