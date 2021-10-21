<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<body>
    <?php 
        include 'conexao.php';

        $oDados = mysqli_query($conn, 'SELECT CAST(RAND()*256 AS UNSIGNED) R, CAST(RAND()*256 AS UNSIGNED) G, CAST(RAND()*256 AS UNSIGNED) B, PARTIDO_VOTO, NOME, COUNT(0) TOTAL FROM VOTOS INNER JOIN PARTIDOS ON ID = PARTIDO_VOTO GROUP BY PARTIDO_VOTO;');

        $vCand = array();
        $vVoto = array();
        $vCores = array();

        while($vReg = mysqli_fetch_assoc($oDados))
        {
            $vCand[] = $vReg['PARTIDO_VOTO'];
            $vVoto[] = $vReg['NOME'];
            $vCores[] = "rgb(". $vReg['R'] .",". $vReg['G'] .",". $vReg['B'] .")";
        }
            echo json_encode($vCand);
            echo json_encode($vVoto);
            echo json_encode($vCores);
            

        $conn->close(); 
    ?>

    <body>
        <div>
            <canvas id="Painel">
                <canvas>
        </div>
    </body>

    <script src="http://192.168.0.9/AlunoFTP/ChartJS/Chart.js">

    </script>

    <script type="text/javascript">
        let grafico = new Chart(document.getElementById('Painel').getContext('2d'), {
            type: 'pie',
            data: {
                datasets: [{
                    data: <?php echo json_encode($vCand); ?> ,
                    backgroundColor: [<?php echo json_encode($vCores);?>],
                    label: 'eleição'
                }],

                labels: <?php echo json_encode($vVoto); ?>
            }
        });
    </script>

</body>

</html>


<!-- 'SELECT PARTIDO_VOTO, NOME, COUNT(0) TOTAL FROM VOTOS INNER JOIN PARTIDOS ON ID = PARTIDO_VOTO GROUP BY PARTIDO_VOTO;' -->