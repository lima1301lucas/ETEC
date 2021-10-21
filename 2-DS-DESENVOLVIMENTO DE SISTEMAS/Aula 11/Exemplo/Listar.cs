using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace exemplo
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        public void Pesquisa(string valor)
        {
            //executar ações no banco
            MySqlDataAdapter tabela = new MySqlDataAdapter("select RUANOME RUA , lclnome BAIRRO from XRUAS left join LOCAIS on lclcodigo=RUALOCAL where RUANOME like'%" + valor + "%'", Form1.conexao);
            //left join junção que usa no SQL e relaciona mais de uma tabela
            //funçao que quer executar, aonde quer executar

            //associa com o objeto no VS
            DataTable dados = new DataTable();

            //Relaciona os dois obj
            tabela.Fill(dados);

            //Pegando os dados e colocando no datagrid
            lista.DataSource = dados;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            Pesquisa(" ");
        }

        private void btniserir_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Form1.conexao;
            String ruanome = txtpesquisa.Text;
            String rualocal = txtnumero.Text ;
            comando.CommandText = "Insert into XRUAS (RUANOME, RUALOCAL) values ('" + ruanome + "' , '" + rualocal + "')";
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados inseridos !");
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa(txtpesquisa.Text);
            
        }
    }
}
