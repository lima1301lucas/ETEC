meuBanner = new Array(3);
    meuBanner[0] = "img/imagemmmm.jpg";
    meuBanner[1] = "img/titulo.jpg";
    meuBanner[2] = "img/imagemmmm.jpg";
    contador = 0
    tempo = 2500;
    function banner(){
        contador++;
        contador = contador % 3;
        document.figura.src =
 meuBanner[contador];
        setTimeout("banner()", tempo);
    }