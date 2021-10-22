<?php

include 'conexao.php';
if(isset($_GET['btnSalvar']))
{
    $cSQL = "INSERT INTO gastos(GSTNOME, GSTVALOR, GSTDATA) VALUES('" . $_GET['txtGasto'] . "',".$_GET['txtValor'].",'".$_GET['txtData']."')";
    if(mysqli_query($oCon, $cSQL))
    {
        echo "<script>alert('Registro inserido com sucesso!');document.location.href='gasto.php'</script>";
    }
    else
    {
        echo "<script>alert('Ocorreu um erro, registro não inserido :(');document.location.href='gasto.php'</script>";
    }
}
if(isset($_GET['btnAlterar']))
{
    $cSQL = "UPDATE gastos SET GSTNOME = '". $_GET['txtGasto2'] ."', GSTVALOR = '" . $_GET['txtValor2'] . "', GSTDATA = '" . $_GET['txtData2'] . "' WHERE GSTCODIGO = " . $_GET['slcGasto'];
    if(mysqli_query($oCon, $cSQL))
    {
        echo "<script>alert('Registro alterado com sucesso!');document.location.href='gasto.php'</script>";
    }
    else
    {
        echo "<script>alert('Ocorreu um erro, registro não alterado :(');document.location.href='gasto.php'</script>";
    }
}
if(isset($_GET['btnDeletar']))
{
    $cSQL = "DELETE FROM gastos WHERE GSTCODIGO = " . $_GET['slcGasto'];
    if(mysqli_query($oCon, $cSQL))
    {
        echo "<script>alert('Registro deletado com sucesso!');document.location.href='gasto.php'</script>";
    }
    else
    {
        echo "<script>alert('Ocorreu um erro, registro nã deletado :(');document.location.href='gasto.php'</script>";
    }
}
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gastos</title>
</head>
<style>
    *{
        background-color: #f6f6f6;
        font-family: arial, sans-serif;
    }

    BODY > CENTER > SELECT{
        border: 2px solid #000000;
        padding: 5px;
        margin: 5px;
        width: 50%;
        font-family: sans-serif;
        font-size: 14px;
        background-color: #00f0f0;
    }

    FORM > LABEL{
        font-size: 20px;
        margin: 0px 20px 0px 0px;
        font-weight: bold;
    }

    FORM{
        display: inline-flex;
        align-items: center;
    }

    FORM > SPAN{
        display: grid;
    }

    FORM > BUTTON{
        border: 2px solid #000000;
        padding: 5px;
        margin: 5px;
        font-family: sans-serif;
        font-size: 14px;
        background-color: #00f0f0;
    }
    FORM > SPAN > LABEL{
        WIDTH: 100%;
        text-align: left;
        font-size: 16px;
    }
    FORM > SPAN > INPUT, FORM > SPAN > SELECT{
        margin: 5px;
        border: 1px solid #000000;
        padding: 2px;
        height: 30px;
        width: 200px;
        font-size: 16px;
    }
</style>
<body>
    <?php 

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

        $vGastos = array();
        $vMeses = array();

        while($vReg = mysqli_fetch_assoc($oDados))
        {
            $vGastos[] = $vReg['GASTOS'];
            $vMeses[] = $vReg['MESES'];
        }

            //echo json_encode($vGastos);
            //echo json_encode($vMeses);
            

         
    ?>

            <center><div style="width:80vw;height:80vh;">
            <canvas id="Painel">
            </canvas>
            </div>
            <form name="frmAdicionar">
                <label>Adicionar novo gasto: </label>
                <span>
                    <label>Nome:</label>
                    <input type="text" name="txtGasto"/>
                </span>
                <span>
                    <label>Valor:</label>
                    <input type="number" step="0.01" name="txtValor">
                </span>
                <span>
                    <label>Data: </label>
                    <input type="date" name="txtData" value="<?php echo date("Y-m-d"); ?>">
                </span>
                <button name="btnSalvar">Salvar</button>
            </form>
            <form name="frmAlterar">
                <label>Altere ou delete um gasto: </label>
                <span>
                    <label>Selecione uma opção:</label>
                    <select name="slcGasto" onchange="fnSelecionar(this.value);">
                        <option value=0> </option>
                        <?php
                            $cSQL = "SELECT GSTCODIGO, GSTNOME, GSTVALOR, DATE_FORMAT(GSTDATA, '%d/%m/%Y')  'GSTDATA', DATE(GSTDATA) 'DATA' FROM gastos";
                            $oDados = mysqli_query($oCon, $cSQL);
                            while($vReg = mysqli_fetch_assoc($oDados))
                            {
                                echo '<option value="' . $vReg['GSTCODIGO'] . '">'. $vReg['GSTNOME'] .' ('. $vReg['GSTDATA'] .')</option>';
                            }
                        ?>
                    </select>
                </span>
                <span>
                    <label>Nome:</label>
                    <input type="text" name="txtGasto2"/>
                </span>
                <span>
                    <label>Valor:</label>
                    <input type="number" step="0.01" name="txtValor2">
                </span>
                <span>
                    <label>Data: </label>
                    <input type="date" name="txtData2">
                </span>
                <button name="btnAlterar">Alterar</button>
                <button name="btnDeletar">Deletar</button>
            </form>
            <br><br>
            <select id="tipoGrafico" onchange="fnTrocar();">
                <option value="line">Gráfico de linha</option>
                <option value="bar">Gráfico de barras</option>
            </select>
            </center>
        </body>
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.js">
        
    </script>

    <script type="text/javascript">
        
        function fnSelecionar(codigo)
        {
            if(codigo != 0)
            {
                let oRetorno = new  XMLHttpRequest();
                oRetorno.open('GET', 'gastos_json.php?nCod='+ codigo);
                oRetorno.send();
                oRetorno.onload = function()
                {
                    // alert(oRetorno.responseText);
                    let dados = JSON.parse(oRetorno.responseText);
                    document.getElementsByName('txtGasto2')[0].value = dados.nome;
                    document.getElementsByName('txtValor2')[0].value = dados.valor;
                    document.getElementsByName('txtData2')[0].value = dados.data;
                };
            }
            else
            {
                document.getElementsByName('txtGasto2')[0].value = "";
                document.getElementsByName('txtValor2')[0].value = "";
                document.getElementsByName('txtData2')[0].value = "";
            }
        }

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
            grafico.data.datasets[0].backgroundColor = 'rgba(255, 0, 0, ' + a + ')';
            grafico.update();
        }
        Chart.defaults.global.defaultFontSize = 18;
        let grafico = new Chart(document.getElementById('Painel').getContext('2d'),
        { type: 'line', //pie, bar, doughnut, area, line
            data: {
                labels: <?php echo json_encode($vMeses);?>,
                datasets: [{
                    label: 'gastos',
                    backgroundColor: 'rgba(255, 0, 0, ' + '0' + ')',
                    borderColor: 'rgb(255, 0, 0)',
                    data: <?php echo json_encode($vGastos);?>,
                    lineTension: '0'
                }
                ]
            },
            options: {
				responsive: true,
				title: {
					display: true,
					text: 'Gasto mensal do ano de 2020',
                    fontSize: 20
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
							labelString: 'Gasto em R$'
						}
					}]
				}
			}
        } 
        );
    </script>
<?php
$oCon->close();
?>
</html>