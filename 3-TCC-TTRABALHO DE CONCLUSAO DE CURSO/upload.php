<?php

if(isset($_FILES['txtArquivo']))
{
    if(move_uploaded_file($_FILES['txtArquivo']['tmp_name'], 'IMG/foto' . $_POST['nCod'] . '.png'))
        header('location: imagem.php');
    else
        echo "<script>alert('A imagem não pode ser cadastrada');document.location.href='imagem.php';</script>";
}
else
{
    echo "<script>alert('A imagem não pode ser cadastrada');document.location.href='imagem.php';</script>";
}

?>