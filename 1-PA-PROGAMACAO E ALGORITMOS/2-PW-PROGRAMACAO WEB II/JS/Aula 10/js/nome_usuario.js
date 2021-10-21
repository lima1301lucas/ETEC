function salvarUsuario() {

    var nome_usuario = cadastro.nome.value;
    localStorage.setItem('salvar_nome', nome_usuario);

    var sobrenome = cadastro.sobrenome.value;
    var cpf = cadastro.cpf.value;
    var datanascimento = cadastro.datanascimento.value;
    var email = cadastro.email.value;
    var endereco = cadastro.endereco.value;
    var telefone = cadastro.telefone.value;

    alert("Confirma os dados digitados ?\n" + nome_usuario +" "+ sobrenome + "\n" + cpf + "\n" + datanascimento + "\n" + email + "\n" + endereco + "\n" + telefone);
}