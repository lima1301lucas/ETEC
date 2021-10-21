<!DOCTYPE html>
<html lang="pt-BR">
<head>
	<meta charset="utf-8">
	<title></title>
</head>
<body>

<?php
//Iniciando a conexão com o bancp de dados

// $cx = mysqli_connect("localhost:3306", "root", "1234");
$cx = mysqli_connect("192.168.0.8:3306", "Aluno2DS", "SenhaBD2");

//selecionando o banco de dados
$db = mysqli_select_db($cx, "junicius");

//criando a query de consulta à tabela criada

$sql = mysqli_query($cx, "SELECT * FROM usuarios") or die(mysqli_error($cx) //caso haja um erro na consulta
);

//percorrendo os registros da consulta.
while($aux = mysqli_fetch_assoc($sql)) {
	echo "VAMOS EXIBIR OS DADOS DA TABELA USUARIOS DO BANCO DE DADOS<br />";
	echo "Nome:".$aux["nome"]."<br />";
	echo "Usuário:".$aux["usuario"]."<br />";
	echo "Senha:".$aux["senha"]."<br />";
	echo "E-mail:".$aux["email"]."<br />";
	echo "Nível:".$aux["nivel"]."<br />";
	echo "Ativo:".$aux["ativo"]."<br />";
	echo "Data do cadastro:".$aux["cadastro"]."<br />";
	echo ".......................................<br />";

}

// $link = mysqli_connect("192.168.0.8:3306", "Aluno2DS", "SenhaBD2", "junicius");
// if (!$link) {
// 	die('Could not connect: '. mysql_error());
// 	mysql_set_charset($link, 'utf-8');
// }
// echo "Conectado com sucesso";

?>

</body>
</html>