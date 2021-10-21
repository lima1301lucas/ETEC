function on() 
{
    document.getElementById("lamp").src="../lâmpada/img/on.jpg";
}

function off() 
{
    document.getElementById("lamp").src="../lâmpada/img/off.jpg";
} 

function blink()
{
    var intervalo =0;
    var contador=0;
    while (contador<10){
        intervalo+=300;
        setTimeout("document.getElementById('lamp').src='../lâmpada/img/on.jpg';",intervalo); 
        
        intervalo +=500;
        setTimeout("document.getElementById('lamp').src='../lâmpada/img/off.jpg';",intervalo);
        contador++;
    
    
    
    
    
    
    }
}