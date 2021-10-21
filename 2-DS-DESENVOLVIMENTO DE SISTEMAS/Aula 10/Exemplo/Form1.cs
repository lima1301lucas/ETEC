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

namespace Aula_9
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao = new MySqlConnection();


        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_Click(object sender, EventArgs e)
        {
            //port=3308; pwd=1234
            conexao.ConnectionString = " server=127.0.0.1; uid=root; SSLMode=none; database=teste";
            conexao.Open();
            MessageBox.Show("Conectado com o banco de dados!");
        }

        private void brn_inserir_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "Insert into dados (tstdescricao) values ('Segundo valor')";
            comando.ExecuteNonQuery();
            MessageBox.Show("Dados inseridos !");
        }

       
    }
}
