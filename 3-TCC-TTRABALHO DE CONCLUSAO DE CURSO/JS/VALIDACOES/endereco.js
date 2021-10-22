function fnNomeEstado(oElemento){
    document.getElementsByName('slcEstado')[0].value = oElemento.options[oElemento.selectedIndex].innerText;
}

function fnLimpa(){
    document.getElementsByName('txtEndereco')[0].value = "";
    document.getElementsByName('txtBairro')[0].value = "";
    document.getElementsByName('txtCidade')[0].value = "";
    document.getElementsByName('slcEstado')[0].value = "";
}

function FnBuscarEndereco(CEP){
    let oRetorno = new  XMLHttpRequest();
    oRetorno.open('GET', 'https://viacep.com.br/ws/'+ CEP +'/json/');
    oRetorno.send();
    oRetorno.onload = function()
    {
        // alert(oRetorno.responseText);
        let endereco = JSON.parse(oRetorno.responseText);
        document.getElementsByName('txtEndereco')[0].value = endereco.logradouro;

        document.getElementsByName('txtBairro')[0].value = endereco.bairro;
        document.getElementsByName('txtCidade')[0].value = endereco.localidade;
        document.getElementsByName('slcEstado')[0].value = endereco.uf;
        //fnNomeEstado(document.all.cmbEstado);
        
    };  
}