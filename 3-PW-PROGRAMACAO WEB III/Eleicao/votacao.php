<?php 
    session_start();

    include 'conexao.php';

    $query = ("SELECT ID, NOME, FOTO, DESCRICAO FROM PARTIDOS;");
    // executa a query
    $dados = mysqli_query($conn, $query) or die(mysql_error());
    // transforma os dados em um array
    $linha = mysqli_fetch_assoc($dados);
    // calcula quantos dados retornaram
    $total = mysqli_num_rows($dados);
?>


<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <link rel="stylesheet" href="css/votacao.css" class="css">
    <title>LOGIN</title>
</head>

<body>
    <div class="geral">
        <form method="POST">
            <input type="hidden" name="rm" value="<?= $_SESSION['funcione'];?>">
            <?php
    // se o número de resultados for maior que zero, mostra os dados
    if($total > 0) {
        // inicia o loop que vai mostrar todos os dados
        do {
            
    ?>
            <div class="partido">
                <label for="part_<?=$linha['ID']?>">
                    <div class="imagem">
                        <img src="upload/<?=$linha['FOTO']?>">
                    </div>
                    <div class="item">
                        <div class="radio">
                            <input type="radio" name="voto" value="<?=$linha['ID']?>" id="part_<?=$linha['ID']?>">
                        </div>
                        <div class="nome">
                            <h1><?=$linha['NOME']?></h1>
                        </div>
                    </div>
                    <div class="descricao">
                        <p><?=$linha['DESCRICAO']?></p>
                    </div>
                </label>
                
            </div>
            <button type="submit" class="btn">VOTAR</button>

            <?php
        // finaliza o loop que vai mostrar os dados
        }while($linha = mysqli_fetch_assoc($dados));
    // fim do if 
    }
?>
    </div>
    </form>
</body>

</html>
<?php
// tira o resultado da busca da memória
mysqli_free_result($dados);
?>

<?php 
    if(isset($_POST['voto'])){

        include 'conexao.php';
        
        $rm = $_POST['rm'];
        $voto = $_POST['voto'];
        
        
        $sql = "INSERT INTO VOTOS (ELEITOR_VOTO, PARTIDO_VOTO) VALUES ('$rm','$voto')";
        
        if ($conn->query($sql) === TRUE) {
            header("Location: agradecimento.php");
        } 
        else {
            echo "Erro: " . $sql . "<br>" . $conn->error;
        }
        $conn->close(); 
    }
?>