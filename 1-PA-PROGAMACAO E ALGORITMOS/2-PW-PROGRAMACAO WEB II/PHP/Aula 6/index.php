<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link rel ="stylesheet" href = "css.css">
</head>
<body>
<div class="CLASSE">
    <h1>Variáveis criadas durante a execução</h1>

    <?php 

    $texto = "São Paulo"; 
    //cria a variável que recebe o valor

    $futuro_identificador = "cidade";
    //futuro_identificador recebe o valor cidade

    $$futuro_identificador = $texto;

    //a variável recebeu o valor cidade 
    //$ faz o valor "cidade" tornar-se variável
    //cidade recebe a variável texto 

    echo "Minha cidade é $cidade";
    ?>


    <h1>Função recursiva</h1>
    <?php
    //função recursiva é aquela função que chamam elas mesmas

    function teste ($valor){
        if($valor != 0){
            echo "Foi chamada a função teste passando valor $valor <br>";
            teste($valor -1);
        }
    }teste(3);
    ?>

    <h1>Break</h1>
    <?php
    //Este comando oferece forçar a saida de um laço ou de um comando condicional
    $k = 0;
    $i = 0;
    
    while($k <10)
    {
        $i++;
        $k++;
        while ($i < 20)
        {
            if ($i == 10)
            {
              echo "encerramento o primeiro while..<br>";
              break;
              echo "essa linha não vai ser impressa!";
            }
            else if ($i == 15)
            {
                echo "encerramento os dois while..";
                break 2;
            }
            $i++;
        }
    }
    ?>

    <h1>Classe - abstrata e interface</h1>
    <?php 
    // Ultilizamos as palavras private e protect para criar métodos e variáveis privadas e protegidas em uma classe
    
    class Classe1{
        private function MetodoPrivado(){
            echo "classe1::MetodoPrivado()
            chamado.<br>";
        }
    

        protected function MetodoProtegido(){
            echo "classe1::MetodoProtegido()
            chamado.<br>";
            $this -> MetodoProtegido();
        }
    }

    class Classe2 extends Classe1{
        public function MetodoPublico(){
            echo "Classe2::MetodoPublico() chamado. <br>";
            $this -> MetodoProtegido();
        }
    }

    $obj = new Classe2;
    $obj->MetodoPublico();
    ?>
    
    </div>


</body>
</html>