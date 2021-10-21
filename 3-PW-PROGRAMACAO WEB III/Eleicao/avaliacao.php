<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css/avaliacao.css" class="css">
    <title></title>
</head>

<body>
    <section class="table-avaliacao">
    <?php

$oConexao = mysqli_connect('192.168.0.8','Aluno3DS', 'SenhaBD3', 'BD_ELEICAO');

echo" <table> ";
echo" <thead> ";
   echo"  <tr> ";
     echo"    <th>Candidato</th> ";
      echo"   <th>Avaliação</th> ";
   echo"  </tr> ";
echo"   </thead> ";

$stmt = $oConexao->prepare('SELECT * from PARTIDOS order by NOME');
                $stmt->execute();
                $result = $stmt->get_result();
                while($row = mysqli_fetch_array($result)) {

       echo" <tbody> ";
        echo"    <tr> ";
            echo"    <td>".$row['NOME']."</td> ";
          echo"      <td><img src='img/avaliacao.png' onclick='fnModificar(this, event,". $row['ID'].")'></td>"; // this: objeto que sofreu a ação (o evento click ocorreu na imagem) event: guarda os dados do evento que ocorreu ex: posição do mouse / tudo relativo ao evento ele trás dentro da variável
         echo"   </tr> ";

                }

                echo"  </tbody> ";
                echo"  </table> ";

    mysqli_free_result($result);
    mysqli_close($oConexao);
    ?>
</section>
</body>
<script>
    function fnModificar(imagem, dados, partido) {
        console.log(dados);

        let avaliacao;

        if (dados.clientX < 499 + dados.target.parentElement.parentElement.parentElement.parentElement.offsetLeft) {
            imagem.style.background = 'linear-gradient(to right, #f0f000 19%, #FF0000 19%)';
            avaliacao = 1;
        }

        if (dados.clientX > 499 + dados.target.parentElement.parentElement.parentElement.parentElement.offsetLeft && dados.clientX < 539 + dados.target.parentElement.parentElement.parentElement.parentElement.offsetLeft) {
            imagem.style.background = 'linear-gradient(to right, #f0f000 39%, #FF0000 39%)';
            avaliacao = 2;
        }

        if (dados.clientX > 539 + dados.target.parentElement.parentElement.parentElement.parentElement.offsetLeft && dados.clientX < 579 + dados.target.parentElement.parentElement.parentElement.parentElement.offsetLeft) {
            imagem.style.background = 'linear-gradient(to right, #f0f000 59%, #FF0000 59%)';
            avaliacao = 3;
        }

        if (dados.clientX > 579 + dados.target.parentElement.parentElement.parentElement.parentElement.offsetLeft && dados.clientX < 620 + dados.target.parentElement.parentElement.parentElement.parentElement.offsetLeft) {
            imagem.style.background = 'linear-gradient(to right, #f0f000 78%, #FF0000 59%)';
            avaliacao = 4;
        }

        if (dados.clientX > 620 + dados.target.parentElement.parentElement.parentElement.parentElement.offsetLeft) {
            imagem.style.background = 'linear-gradient(to right, #f0f000 100%, #FF0000 59%)';
            avaliacao = 5;
        }


        let oResposta = new XMLHttpRequest();
        oResposta.open('GET', 'avaliacao.php?partido=' + partido + '&avaliacao=' + avaliacao);
        oResposta.send();

        oResposta.onload = function () {
            // oDados = JSON.parse(oResposta.responseText);
            //alert(oResposta.responseText);
        }

    }
</script>
</body>

</html>