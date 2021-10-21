<?php
    session_start();
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/cabecalho.css">
    <title></title>
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
            <input type="text" name="txtPesquisa" class="inp-pesquisa" id="txtPesquisa" placeholder="Pesquisa" onKeyUp="if(event.keyCode==13) frmPesquisa.submit()" autocomplete="off">
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
</body>

</html>