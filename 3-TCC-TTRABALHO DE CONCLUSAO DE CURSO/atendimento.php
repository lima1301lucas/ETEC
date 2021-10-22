<?php
session_start();
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Atendimento ao Cliente</title>
    <link rel="icon" href="IMG/icon.png">
    <link rel="stylesheet" href="CSS/atendimento.css">
</head>

<body>
    <?php include 'cabecalho.php'; ?>
    <main>
    <div class="titulo">
        <h1>ATENDIMENTO<h1>
    </div>
    <div class="perguntas">
        <p>Perguntas Frequentes</p>
        <div class="pe">
            <input type='checkbox' id='pergunta-1'>
            <label for='pergunta-1'><b>Qual é o método de pagamento disponível para as compras?</b></label>
            <div class="resposta">
                <span class="spn-res">RESPOSTA:</span>&nbsp;Utilizamos o Mercado Pago como plataforma de pagamento. Ela aceita as seguintes bandeiras de cartão de crédito: Visa, Mastercard, Hipercard, American Express, Diners, Elo e Cartão MercadoLivre.
            </div>
        </div>
        <div class="pe">
            <input type='checkbox' id='pergunta-2'>
            <label for='pergunta-2'><b>Qual é a medida dos produtos anunciados?</b></label>
            <div class="resposta">
                <span class="spn-res">RESPOSTA:</span>&nbsp;Todos os produtos anunciados tem suas medidas dadas em (cm). Se você tiver alguma dúvida basta entrar em contato conosco através do Whatsapp: <b>(11)94244-4613</b> e Instagram: <b>pigmeustore</b>.
            </div>
        </div>
        <div class="pe">
            <input type='checkbox' id='pergunta-3'>
            <label for='pergunta-3'><b>Como posso entrar em atendimento?</b></label>
            <div class="resposta">
                <span class="spn-res">RESPOSTA:</span>&nbsp;Se você tiver acessando o site no notebook ou desktop no canto inferior direito tem dois ícones do intagram e do whatsapp. Você pode clicar e entrar em contato por lá. Se você tiver no tablet ou smartphone basta você pegar aqui. Whatsapp: <b>(11)94244-4613</b> e Instagram: <b>pigmeustore</b>. Também temos e-mail <b>admpigmeu@gmail.com</b>
            </div>
        </div>
        <div class="pe">
            <input type='checkbox' id='pergunta-4'>
            <label for='pergunta-4'><b>Quanto tempo tenho para me arrepender da compra?</b></label>
            <div class="resposta">
                <span class="spn-res">RESPOSTA:</span>&nbsp;De acordo com o CDC (Código de Defesa do Consumidor), você têm 7 dias após o recebimento do produto na sua casa. Para realizar a devolução no rodapé disponibilizamos o passo-a-passo de como fazer esse processo basta acessar a <b>Política de devolução</b>
            </div>
        </div>
        <div class="pe">
            <input type='checkbox' id='pergunta-5'>
            <label for='pergunta-5'><b>Quanto tempo tenho para trocar o produto?</b></label>
            <div class="resposta">
                <span class="spn-res">RESPOSTA:</span>&nbsp;De acordo com a nossa política de troca o cliente possui até 30 dias após a entrega para entrar em contato, No rodapé você pode acessar a nossa <b>Política de devolução</b> e ter mais detalhes sobre.
            </div>
        </div>
        <div class="pe">
            <input type='checkbox' id='pergunta-6'>
            <label for='pergunta-6'><b>Como funciona a entrega dos produtos?</b></label>
            <div class="resposta">
                <span class="spn-res">RESPOSTA:</span>&nbsp;Padronizamos todas nossas entregas com Sedex não cobramos nada a mais por isso. Assim que seu pedido tiver o código de rastreio você consegue conferir no detalhe do seu pedido, basta clicar no + na página de meus pedidos.</div>
        </div>
    </div>
    <div class="whatsapp">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
        <a href="https://wa.me/5511942444613?text=Ol%C3%A1%2C%20tenho%20uma%20d%C3%BAvida!" class ="icon-wpp"
        target="_blank">
            <i style="margin-top:16px" class="fa fa-whatsapp"></i>
        </a>
    </div>
    <div class="instagram">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
        <a href="https://www.instagram.com/pigmeustore/" class="icon-instagram" target="_blank">
            <i style="margin-top:16px"><img src="IMG/ICONE/instagram.svg" class="icon-insta"></i>
        </a>
    </div>
</main>
    <?php include 'rodape.php'; ?>
</body>

</html>