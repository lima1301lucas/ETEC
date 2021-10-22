function validarSenha(name1, name2) {
    var senha1 = document.getElementById('pass').value;
    var senha2 = document.getElementById('con-pass').value;
    mostrar_resposta = document.getElementById("mostra-con");

    if (senha1 != "" && senha2 != "" && senha1 === senha2) {
        mostrar_resposta.innerHTML = '<tr><td bgcolor="green"></td><td>Senhas coincidem</td></tr>';
    } else {
        mostrar_resposta.innerHTML = '<tr><td bgcolor="red"></td><td>Senhas diferem</td></tr>';
    }
}