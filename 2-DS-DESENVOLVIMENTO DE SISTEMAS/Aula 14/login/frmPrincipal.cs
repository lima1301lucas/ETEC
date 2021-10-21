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
    public partial class frmPrincipal : Form
    {
        public static MySqlConnection oConexao = new MySqlConnection();

        public static int codigo;
        public static string nome;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            oConexao.ConnectionString = "server=192.168.0.8; uid=Aluno2DS; pwd=SenhaBD2; database=EXEMPLO";
            oConexao.Open();
            MessageBox.Show("Conectado!");     

            new frmLogin().ShowDialog(); //intanciando e carregando o formulário. O form principal não abre sim o secundário
            Text = "Bem Vindo," + nome;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alteraçãoDeSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAlteracaoSenha().Show();
        }

        private void bloqueioDesbloqueioDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBloqueiaUsuario().Show();
        }

        private void cadastrarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadastro().Show();
        }
    }
}
