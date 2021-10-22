<?php
$Cod = 0;

if(isset($_GET['nCod']))
    $Cod = $_GET['nCod'];
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form id="frmImg" method="POST" enctype="multipart/form-data" action="upload.php">
        <img id="imgPrev" src=<?php if($Cod != 0) echo 'IMG/foto'. $Cod .'.png'; else echo 'IMG/cart16.png'; ?> style="width:100%; height:100%;" onclick="document.getElementById('fileImg').click()" onerror="this.src='IMG/cart16.png'" require />
        <input id="nCod" name="nCod" type="hidden" value=<?php echo $Cod; ?> require>
        <input id="fileImg" type="file" accept="image/*" name="txtArquivo" onchange="fnExibeArquivo(this);" style="width:100%;visibility:hidden;"/>
    </form>
</body>
<script>
    function fnExibeArquivo(oArquivo)
    {
        if(oArquivo.files && oArquivo.files[0])
        {
            let oImagem = new FileReader();
            oImagem.onload = function(oDados)
            {
                document.all.imgPrev.src = oDados.target.result;
            }
            oImagem.readAsDataURL(oArquivo.files[0]);
        }
    }
</script>
</html>