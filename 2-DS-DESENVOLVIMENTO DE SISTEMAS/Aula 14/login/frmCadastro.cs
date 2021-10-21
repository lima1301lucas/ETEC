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
namespace login
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            MySqlCommand oInstrucao = new MySqlCommand();
            oInstrucao.Connection = frmPrincipal.oConexao;

            oInstrucao.CommandText = "INSERT INTO USUARIOS (NOME, LOGIN, SENHA, BLOQUEIO) VALUES (@nome, @login, md5(@senha), 0)";

            oInstrucao.Parameters.Add("@nome", MySqlDbType.VarChar).Value = ctx_nome.Text;
            oInstrucao.Parameters.Add("@login", MySqlDbType.VarChar).Value = ctx_login.Text;
            oInstrucao.Parameters.Add("@senha", MySqlDbType.VarChar).Value = ctx_senha.Text;

            oInstrucao.ExecuteNonQuery();
            MessageBox.Show("Usuário cadastrado!");
            Close();
        }

        private void ctx_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
