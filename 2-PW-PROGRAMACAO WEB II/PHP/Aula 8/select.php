<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
<h1>Recebendo dados do formulário select</h1>

<?php 

  echo"seu processador é: " . $_POST["processador"] ."<br>";

  if(isset($_POST["livros"])){
      echo"O(s) livros que você deseja comprar: <br>";
      foreach($_POST["livros"]as $livro){
          echo"- " . $livro . "<br>";
      }
  }
  else{
      echo"Livro não escolhido!";
  }

?>
    
</body>
</html>