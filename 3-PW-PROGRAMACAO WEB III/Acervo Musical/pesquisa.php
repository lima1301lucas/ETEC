<!DOCTYPE html>
<html lang="pt-br">

<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="stylesheet" href="CSS/pesquisa.css">
	<title>Pesquisa</title>
</head>

<body>

	<header>
		<div class="logotipo">
			<img src="IMG/logotipo.png">
		</div>

		<div>
		</div>
		<div class="pesquisa">
			<form id="frmPesquisa" action="pesquisa.php" class="frmPesquisa">
				<input type="text" name="txtPesquisa" class="inp-pesquisa" id="txtPesquisa" placeholder="Pesquisa"
					onKeyUp="if(event.keyCode==13) frmPesquisa.submit()" autocomplete="off">
				<div class="img-pesquisa">
					<button name="cmdPesquisa" class="img-pesquisa">
						<img src="IMG/ICONES/search.svg" class="img-lupa">
					</button>
				</div>
			</form>
		</div>

		<div class="lista">
			<li class="links">
				<a href="#">
					<img src="IMG/ICONES/disc.svg" class="icon">
					<span>Álbuns</span>
				</a>
			</li>
			<li class="links">
				<a href="#">
					<img src="IMG/ICONES/music.svg" class="icon">
					<span>Músicas</span>
				</a>
			</li>
			<li class="links">
				<a href="#">
					<img src="IMG/ICONES/users.svg" class="icon">
					<span>Artistas/Bandas</span>
				</a>
			</li>
			<li class="links">
				<a href="#">
					<img src="IMG/ICONES/radio.svg" class="icon">
					<span>Rádios</span>
				</a>
			</li>
			<li class="links">
				<a href="#">
					<img src="IMG/ICONES/mic.svg" class="icon">
					<span>Podcasts</span>
				</a>
			</li>
		</div>

		<div class="music-player">
			<div class="titulo">
				<marquee>
					<p class="nome-musica">Nome da música</p>
				</marquee>
			</div>
			<div class="player">
				<div class="repete">
					<img src="IMG/ICONES/repeat.svg" class="opcao">
				</div>
				<div class="trocar-esquerda">
					<img src="IMG/ICONES/skip-back.svg" class="opcao">
				</div>
				<div class="pause">
					<img src="IMG/ICONES/play.svg" class="opcao">
				</div>
				<div class="trocar-direita">
					<img src="IMG/ICONES/skip-forward.svg" class="opcao">
				</div>
				<div class="aleatorio">
					<img src="IMG/ICONES/shuffle.svg" class="opcao">
				</div>
			</div>
		</div>
	</header>

	<?php
$nPag = 0;
if(isset($_GET['txtPagina']))
	$nPag = (int)$_GET['txtPagina'];

if(isset($_GET['cmdRetornar']))
	$nPag--;

if(isset($_GET['cmdAvancar']))
	$nPag++;

if(isset($_GET['txtPesquisa']) && !isset($_GET['cmdRetornar'])
		&& !isset($_GET['cmdAvancar']))
	$nPag = 0;

$nPag = max(0, $nPag);

$cPesquisa = "";
if(isset($_GET['txtPesquisa']))
	$cPesquisa = str_replace("'", "''", $_GET['txtPesquisa']);
?>
	<section class="sec-pesquisa">
		<form id="frmPesquisa">
			<?php
	$oCon = mysqli_connect('localhost','root','','ACERVO');
	mysqli_set_charset($oCon, 'utf8');
	
	$cSQL = "SELECT ALBCODIGO, ALBNOME 'NOME ', IFNULL(IFNULL(ARTNOME, BDSNOME), 
				'Coletânea') 'INTÉRPRETE', GROUP_CONCAT(MSCNOME SEPARATOR '; ') MÚSICAS, 
				CONCAT('<span title=\"Nome completo da musica\">', GROUP_CONCAT(MSCNOME SEPARATOR '</span><span>'), '</span>') 'Músicas'" .
				"  FROM ALBUNS" .
				"  LEFT JOIN ARTISTAS ON ALBARTISTA = ARTCODIGO" .
				"  LEFT JOIN BANDAS ON ALBBANDA = BDSCODIGO" .
				"  LEFT JOIN FAIXAS ON ALBCODIGO = FXSALBUM" .
				"  LEFT JOIN MUSICAS ON FXSMUSICA = MSCCODIGO" .
				" WHERE 1 = 1";
				
	if(isset($_GET['txtPesquisa']))
		$cSQL .= "	AND (ALBNOME LIKE '%" . $cPesquisa . "%'" .
		"	OR BDSNOME LIKE '%" . $cPesquisa . "%'" .
		"	OR ARTNOME LIKE '%" . $cPesquisa . "%'" .
		"	OR MSCNOME LIKE '%" . $cPesquisa . "%')";
	
	$cSQL .=" GROUP BY ALBCODIGO, ALBNOME, 
	IFNULL(IFNULL(ARTNOME, BDSNOME), 'Coletânea')" . " LIMIT " . ($nPag * 20) . ", 20";
	$oDados = mysqli_query($oCon, $cSQL);
	//echo $cSQL;
	
	$nProximo = !(mysqli_num_rows($oDados)<20);
	//echo $nProximo;
	
	echo "<table><thead><tr>";
	$cNomes = mysqli_fetch_fields($oDados);
	$cNomes = array_slice($cNomes, 1, 3);
	//$cNomes[0] = new stdClass();
	//$cNomes[0] ->name = "#";
	
	echo '<th></th>';
	foreach($cNomes as $cNome)
		echo '<th>' . $cNome->name . '</th>';
	echo '</tr></thead><tbody>';
	
	while ($vReg=mysqli_fetch_assoc($oDados))
	{
		$nPos = 0;
		$cAux = "";
		echo "<tr>";
		foreach($vReg as $cCampo)
		{
			if($nPos==0)
		
				echo '<td><input name="txtCodigo" class="radio" type="radio" value="' . $cCampo . '" /></td>';
			else
				if($nPos==3)
					$cAux = $cCampo;
				else
					if($nPos==4)
						echo "<td><details><summary>" . $cAux . "</summary>" . $cCampo . "</details></td>";
					else
						echo "<td>" . $cCampo . "</td>";
			$nPos++;
		}
		echo "</tr>";
	}
	echo "</tbody></table>";
	
	mysqli_free_result($oDados);
	mysqli_close($oCon);
	?>
			<div class="comando">
				<input type="hidden" name="txtPagina" value="<?php echo $nPag; ?>" />
				<button name="cmdRetornar" class="comand" <?php echo $nPag==0?'DISABLED':''; ?>>&lt;</button>
				<div class="n">
				<label class="npagina"><?php echo $nPag+1; ?></label>
				</div>
				<button name="cmdAvancar" class="comand" <?php echo $nProximo?'':'DISABLED'; ?>>&gt;</button>
			</div>
		</form>
	</section>
</body>

</html>