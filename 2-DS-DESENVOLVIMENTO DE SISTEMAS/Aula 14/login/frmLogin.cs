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
    public partial class frmLogin : Form
    {
        byte tentativas = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlCommand oComando = new MySqlCommand();
            oComando.Connection = frmPrincipal.oConexao;

            oComando.CommandText = "SELECT CODIGO, NOME FROM USUARIOS WHERE LOGIN = @login and SENHA = md5(@senha)";//md5 criptografa a senha no banco de dados

            oComando.Parameters.Add("@login", MySqlDbType.VarChar).Value = txt_login.Text;//variáveis no C#
            oComando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txt_senha.Text;

            MySqlDataReader oDados;
            oDados = oComando.ExecuteReader();

            if (oDados.Read())
            {
                frmPrincipal.codigo = oDados.GetInt32("CODIGO");
                frmPrincipal.nome = oDados.GetString("NOME");
                oDados.Close();
                Close();
            }

            else
            {
                oDados.Close();
                MessageBox.Show("Usuário ou senhas incorretos!");
                tentativas++;

                if(tentativas > 3)
                {
                    MessageBox.Show("Tentativas excedidas! Fechando aplicação");
                    Application.Exit();
                }
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            new frmCadastro().Show();
        }

        private void Limpar(object sender, EventArgs e)
        {
            txt_login.Text = "";   
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar2(object sender, EventArgs e)
        {
            txt_senha.Text = "";
        }

        private void apertar(object sender, MouseEventArgs e)
        {
            txt_senha.UseSystemPasswordChar = false;
        }

        private void soltar(object sender, MouseEventArgs e)
        {
            txt_senha.UseSystemPasswordChar = true;
        }

        private void Senha_Tick(object sender, EventArgs e)
        {

        }
    }
}
