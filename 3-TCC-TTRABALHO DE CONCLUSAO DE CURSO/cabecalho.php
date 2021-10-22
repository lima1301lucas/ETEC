<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/header.css">
    <link rel="icon" href="IMG/icon.png">
    <title></title>
</head>

<body>
    <header>
        <div class="container">
            <div class="content-header">
                <a href="index.php">
                    <img src="IMG/logo.png">
                </a>
                <button class="open-nav">
                    <span class="line line_1"></span>
                    <span class="line line_2"></span>
                    <span class="line line_3"></span>
                </button>
                <nav class="menu">
                    <ul class="list-menu">
                        <?php
                            if(isset($_SESSION['USRNOME']))
                            {
                                $pNome = $_SESSION['USRNOME'];
                                $nome = explode(" ", $pNome);
                                echo '<li class="list-nome"> Olá, ' . $nome[0] . ' <li>
                                <li><a href="atendimento.php">Atendimento</a></li>
                                <li><a href="pedidos.php">Meus Pedidos</a></li>
                                <li><a href="alterar.php">Minha conta</a></li>
                                <li><a href="carrinho.php">Carrinho</a></li>
                                <li><a href="logout.php">Sair</a></li>';
                            }
                            else
                            {   
                                echo '<li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href=""></a></li>
                                <li><a href="atendimento.php">Atendimento</a></li>
                                <li><a href="cadastro.php">CADASTRE-SE</a></li>
                                <li><a href="login.php">Login</a></li>';
                            }           
                        ?>
                    </ul>
                </nav>
            </div>
        </div>
    </header>
</body>
<script src="https://code.jquery.com/jquery-2.2.4.min.js"></script>
<script src="JS/ELEMENTOS/menu.js"></script>

</html>