
<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="CSS/index.css">
  <title></title>
</head>
<body>
  <?php
    include 'cabecalho.php'; 
  ?>
  <section class="sec-nome">
    <div class="nome">
      <button class="open-modal" onclick="abrirModal()">
        <?php
        if(isset($_SESSION['USRNOME'])){
          $pNome = $_SESSION['USRNOME'];
          $nome = explode(" ", $pNome);
          echo 'Bem vindo, ' . $nome[0]; 
        }
        else
          echo 'Login';
        ?>
      </button>
    </div>
    <div class="bg-modal" id="modal">
      <div class="modal">
        <img src="IMG/ICONES/x.svg" class="close" onclick="fecharModal()">
        <?php include 'login.php'; ?>
      </div>
    </div>
  </section>

  <section class="conteudo" id="sec">
    <div class="principal">
      <div class="item">
        <p class="titulo">Suas playlists</p>
        <img src="IMG/playlist.png" class="icon-item">
      </div>
      <div class="item">
        <p class="titulo">Descubra</p>
        <img src="IMG/descubra.png" class="icon-item">
      </div>
      <div class="item">
        <p class="titulo">Gêneros</p>
        <img src="IMG/generos.png" class="icon-item">
      </div>
      <div class="item">
        <p class="titulo">Hot 100</p>
        <img src="IMG/hot.png" class="icon-item">
      </div>
    </div>
    <div class="secundaria">
      <div class="item">
        <p class="titulo">Favoritos</p>
        <img src="IMG/fav.png" class="icon-item">
      </div>
      <div class="item">
        <p class="titulo">Vem por ai</p>
        <img src="IMG/calendar.png" class="icon-item">
      </div>
    </div>
  </section>

</body>

<script type="text/javascript">

  function abrirModal(){
    document.getElementById('modal').style.top = "0";
  }

  function fecharModal(){
    document.getElementById('modal').style.top = "-100%";
  }
</script>

</html>