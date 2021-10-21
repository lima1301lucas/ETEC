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
    <?php
				echo "O valor de CAMPO 1 é: " . $_POST["campo1"];
                echo "<br>O valor de CAMPO 2 é: " . $_POST["campo2"];
                echo "<br> valor de CAMPO 3 é: " . $_POST["campo3"];
				echo "<br>O valor de CAMPO 4 é: " . $_POST["campo4"];

	?>
    </div>
</body>
</html>