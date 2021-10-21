<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <link rel ="stylesheet" href = "css.css">
</head>
<body>
<div class="CLASSE">
    <h1>Classe abstrata e interfaces</h1>

    <?php 
        //Utilizamos as palavras private e protect para criar métodos e variáveis privadas e protegidas em uma classe
    
    abstract class ClasseAbstrata{
        abstract public function teste();
    }
    
        class ClasseImplementacao extends ClasseAbstrata{
            public function teste(){
                echo "Método teste () chamado! <br>";
            }
        }
    
        $obj = new ClasseImplementacao;
        $obj -> teste();

    
    ?>
    

    <br>
     <h1>Formulário PHP</h1>
    
    <form name="index.php" method="post">
        Campo 1: <input type="text" name="campo1"><br>
        Senha: <input type="text" name="campo2"><br>
        <input type="submit" value="OK">
    </form>
        
    
     <h1>Recebe Dados</h1>
    
    <?php 
    echo "o valor de CAMPO 1 é: " . $_POST["campo1"];
    echo "<br>o valor de CAMPO 2 é: " . $_POST["campo2"];
    ?>
        
    
    <h1>Método require e include</h1>
    <?php
    
        include('index.html');
           /* include('index.html');
            
            echo"modo requeire";
    require('index.php');
    require_once('index.php');*/
    ?>
    </div>


</body>
</html>