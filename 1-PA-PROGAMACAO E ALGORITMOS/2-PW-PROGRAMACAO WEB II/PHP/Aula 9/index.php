<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css.css">
    <title>Cadastro</title>
</head>
<body>
    <div class="formatacao">
    <div class="dados">
    <form action ="recebedados.php" method="post">
    <h1>Xiaomi Brasil</h1>
        <p></p>
    <h2>Preencha seus dados e vamos lá!</h2>

    <div class="nome">
    <label>Nome:</label>
    <input type="text" name="nome" size="50"><br><br>
    </div>

    <div class="data">
    <label>Data de nascimento</label>    
    <input type="date" name="datanasc"><br><br>
    <div>

    <div class="email">
    <label>Email</label>
    <input type="text" name="email"><br><br>
    </div>
    
    <div class="senha">
    <label>Senha</label>
    <input type="password" name="senha"><br><br>
    </div>
    
    <div class="confirma">
    <label>Confirmar senha</label>
    <input type="password" name="confirma_senha"><br><br>
    </div>
    </div>

    <h2>Você possuiu ou possui alguns dos celulares dos seguintes modelos abaixo ?</h2>

    <input type= checkbox name="modelos[]" value=Redmi7>Redmi note 7<br><br>

    <input type= checkbox name="modelos[]" value=Redmi6>Redmi 6 / Redmi 6 Pro<br><br>

    <input type= checkbox name="modelos[]" value=Redmigo>Redmi GO<br><br>

    <input type= checkbox name="modelos[]" value=Mioito>Mi 8 / Mi 8 lite<br><br>

    <input type= checkbox name="modelos[]" value=Minove>Mi 9 / Mi 9 SE / Mi 9 T<br><br>

    <input type= checkbox name="modelos[]" value=MiA>Mi A2 / Mi A2 Lite<br><br>

    <input type= checkbox name="modelos[]" value=MiAtres>Mi A3<br><br>

    <input type= checkbox name="modelos[]" value=Mimax>Mi Max<br><br>

    <input type= checkbox name="modelos[]" value=Mimix>Mi Mix<br><br>

    <input type= checkbox name="modelos[]" value=Pocophone>Pocophone F1<br><br>

   
    <h2>O que você acha do custo benefício ?</h2>

    <input type= radio name="linha" value="Insatisfatorio">Insatisfatório<br><br>

    <input type= radio name="linha" value="Regular">Regular<br><br>

    <input type= radio name="linha" value="Bom">Bom<br><br>

    <input type= radio name="linha" value="Muito Bom">Muito bom<br><br>

    <h2>Qual foi o valor pago ?</h2>

    <select name="preco">
        <option selected disable></option>
        <option value="500,00 até 1.000,00">De R$ 500,00 - 1.000,00</option>
        <option value="1.000,00 até 1.500,00">De R$ 1.000,00 - 1.500,00</option>
        <option value="1.600,00 até 2.000,00">De R$ 1.600,00 - 2.000,00</option>
        <option value="2.100,00 até 2.500,00">De R$ 2.100,00 - 2.500,00</option>
        <option value="2.600,00 até Superior">De R$ 2.600,00 - Superior</option>
    </select><br><br><br>

    <input type = submit>
    </div>
    </form>
    </div>
    
</body>

</html>