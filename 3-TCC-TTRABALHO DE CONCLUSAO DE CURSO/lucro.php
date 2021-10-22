<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Lucros</title>
    <link rel="stylesheet" href="stylecand.css">
</head>
<style>
    *{
        background-color: #f6f6f6;
    }

    SELECT{
        border: 2px solid #000000;
        padding: 5px;
        margin: 5px;
        width: 50%;
        font-family: sans-serif;
        font-size: 14px;
        background-color: #00f0f0;
    }
</style>
<body>
    <?php 
       include 'conexao.php';

        $cSQL = "SELECT ('Janeiro') 'MESES', IFNULL(SUM(ITEVALOR), 0)'SOMA' FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO
         WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 1 UNION SELECT 'Fevereiro', IFNULL(SUM(ITEVALOR), 0) FROM itens 
         INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 2 UNION SELECT 'Março', 
         IFNULL(SUM(ITEVALOR), 0) FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' 
         AND MONTH(PDDDATA) = 3 UNION SELECT 'Abril', IFNULL(SUM(ITEVALOR), 0) FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO 
         WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 4 UNION SELECT 'Maio', IFNULL(SUM(ITEVALOR), 0) FROM itens INNER JOIN pedido 
         ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 5 UNION SELECT 'Junho', IFNULL(SUM(ITEVALOR), 0) 
         FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 6 UNION SELECT 'Julho', 
         IFNULL(SUM(ITEVALOR), 0) FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 7 
         UNION SELECT 'Agosto', IFNULL(SUM(ITEVALOR), 0) FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' 
         AND MONTH(PDDDATA) = 8 UNION SELECT 'Setembro', IFNULL(SUM(ITEVALOR), 0) FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO 
         WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 9 UNION SELECT 'Outubro', IFNULL(SUM(ITEVALOR), 0) FROM itens INNER JOIN pedido 
         ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 10 UNION SELECT 'Novembro', IFNULL(SUM(ITEVALOR), 0) 
         FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 11 UNION SELECT 'Dezembro', 
         IFNULL(SUM(ITEVALOR), 0) FROM itens INNER JOIN pedido ON PDDCODIGO = ITEPEDIDO WHERE PDDDATA LIKE '2020-%' AND MONTH(PDDDATA) = 12";

        $oDados = mysqli_query($oCon, $cSQL);

        $vSoma = array();
        $vMeses = array();

        while($vReg = mysqli_fetch_assoc($oDados))
        {
            $vSoma[] = $vReg['SOMA'];
            $vMeses[] = $vReg['MESES'];
        }

        $cSQL = "SELECT ('Janeiro')'MESES', IFNULL(SUM(GSTVALOR), 0)'GASTOS' FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 1 
        UNION SELECT 'Fevereiro', IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 2 UNION SELECT 'Março', 
        IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 3 UNION SELECT 'Abril', IFNULL(SUM(GSTVALOR), 0) 
        FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 4 UNION SELECT 'Maio', IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA 
        LIKE '2020-%' AND MONTH(GSTDATA) = 5 UNION SELECT 'Junho', IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND 
        MONTH(GSTDATA) = 6 UNION SELECT 'Julho', IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 7 
        UNION SELECT 'Agosto', IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 8 UNION 
        SELECT 'Setembro', IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 9 UNION SELECT 'Outubro', 
        IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 10 UNION SELECT 'Novembro', 
        IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 11 UNION SELECT 'Dezembro', 
        IFNULL(SUM(GSTVALOR), 0) FROM gastos WHERE GSTDATA LIKE '2020-%' AND MONTH(GSTDATA) = 12";

        $oDados = mysqli_query($oCon, $cSQL);

        while($vReg = mysqli_fetch_assoc($oDados))
        {
            $vGastos[] = $vReg['GASTOS'];
        }

            //echo json_encode($vGastos);
            //echo json_encode($vSoma);
            //echo json_encode($vMeses);
        $nCont = 0;
        $vLucro = array();
        while($nCont < 12)
        {
            $vLucro[$nCont] = number_format($vSoma[$nCont] - $vGastos[$nCont], 2, '.', ' ');
            $nCont++;
        }

        
            //echo json_encode($vLucro);

        $oCon->close(); 
    ?>

            <center><div style="width:80vw;height:80vh;">
            <canvas id="Painel">
            </canvas>
            </div>
            <b><select id="tipoGrafico" onchange="fnTrocar();">
                <option value="line">Gráfico de linha</option>
                <option value="bar">Gráfico de barras</option>
            </select></b>
            </center>
        </body>
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.js">
        
    </script>

    <script type="text/javascript">

        let tipo = 'line';
        let a = 0;


        function fnTrocar()
        {
            if(document.getElementById('tipoGrafico').value != 'line')
            {
                a = 255;
                tipo = 'bar';
            }
            else
            {
                a = 0;
                tipo = 'line';
            }
            grafico.config.type = tipo;
            grafico.data.datasets[0].backgroundColor = 'rgba(0, 255, 0, ' + a + ')';
            grafico.data.datasets[1].backgroundColor = 'rgba(0, 0, 255, ' + a + ')';
            grafico.update();
        }

        let grafico = new Chart(document.getElementById('Painel').getContext('2d'),
        { type: 'line', //pie, bar, doughnut, area, line
            data: {
                labels: <?php echo json_encode($vMeses);?>,
                datasets: [{
                    label: 'lucro',
                    backgroundColor: 'rgba(0, 255, 0, 0)',
                    borderColor: 'rgb(0, 255, 0)',
                    data: <?php echo json_encode($vLucro);?>,
                    lineTension: '0'
                },
                {
                    label: 'total',
                    backgroundColor: 'rgba(0, 0, 255, 0)',
                    borderColor: 'rgb(0, 0, 255)',
                    data: <?php echo json_encode($vSoma);?>,
                    lineTension: '0'
                }
                ]
            },
            options: {
				responsive: true,
				title: {
					display: true,
					text: 'Lucro mensal do ano de 2020'
				},
				tooltips: {
					mode: 'index',
					intersect: false,
				},
				hover: {
					mode: 'nearest',
					intersect: true
				},
				scales: {
					xAxes: [{
						display: true,
						scaleLabel: {
							display: true,
							labelString: 'Mês'
						}
					}],
					yAxes: [{
						display: true,
						scaleLabel: {
							display: true,
							labelString: 'Lucro em R$'
						}
					}]
				}
			}
        } 
        );
    </script>

</html>