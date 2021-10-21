<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <h1>Formulário Select</h1>
   <form action = "select.php" method="post">
   <B>Qual seu processador?</B><br>
   <select name ="processador">
   <option value="I3">I3</option>
   <option value="I5">I5</option>
   <option value="I7">I7</option>
   </select><br><br>

   <B>Livros que deseja comprar?</B><br>
   Obs: segure "CTRL" para selecionat mais de um.<br>
   <select name="livros[]" multiple>
   <option value="PHP">PHP</option>
   <option value="PHP Etec jaragua">PHP Etec jaraguá</option>
   <option value="iniciando em PHP">Iniciando em php</option>
   <option value="PHP 5">PHP 5</option>
   <option value="MySQL">MySQL</option>
   </select><br><br>
   <input type=submit>
   </form>


   <form action="checkbox.php" method="post">
<b>Números</b>
<br>
<input type= checkbox name="numeros[]" value=10>10<br>

<input type= checkbox name="numeros[]" value=100>100<br>

<input type= checkbox name="numeros[]" value=1000>1000<br>

<input type= checkbox name="numeros[]" value=10000>10000<br>

<input type= checkbox name="numeros[]" value=90>90<br>

<input type= checkbox name="numeros[]" value=50>50<br>

<input type= checkbox name="numeros[]" value=30>30<br>

<input type= checkbox name="numeros[]" value=15>15<br>

<input type= checkbox name="news" value=1><br>
<b>Receber newsletter</b><br>

<input type=submit>



</form>

<form action="radio.php" method="post">
<b>Qual o seu SO</b>
<br>
<input type= radio name="sistema" value="Windows 7">Windows 7<br>
<input type= radio name="sistema" value="Windows 10">Windows 10<br>
<input type= radio name="sistema" value="Linux">Linux<br>
<input type= radio name="sistema" value="Mac">IOS-Mac<br>
<br><br>
<b>Escolha os números de sua  preferência</b><br>
<input type= radio name="monitor" value="Samsung">Samsung<br>
<input type= radio name="monitor" value="LG">LG<br>
<input type= radio name="monitor" value="Desconhecido">Desconhecido<br><br>
<input type=submit>






</form>  
</body>
</html>