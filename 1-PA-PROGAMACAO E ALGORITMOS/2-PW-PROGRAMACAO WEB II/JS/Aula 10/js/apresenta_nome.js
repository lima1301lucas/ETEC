$(document).ready(function(){
    if (((localStorage.getItem("salvar_nome") === null) == false) || (localStorage.getItem("salvar_nome") == "")) {
        var name = document.querySelector('.name-user');
        res = name.innerText.split(',');
        res = res[res.length - 1];
        var newRes = localStorage.getItem("salvar_nome");
        name.innerText = ("Olá, " + newRes).toUpperCase();
    }
    else{
        localStorage.removeItem('.name-user');
    }
    
})