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
    public partial class frmAlteracaoSenha : Form
    {
        public frmAlteracaoSenha()
        {
            InitializeComponent();
        }

        private void frmAlteracaoSenha_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter oTabela = new MySqlDataAdapter("SELECT CODIGO, NOME FROM USUARIOS", frmPrincipal.oConexao);
            DataTable oDados = new DataTable();
            oTabela.Fill(oDados);
            ComboBox_usuarios.DataSource = oDados; //carregou com todos os users

            if (frmPrincipal.codigo == 1)
            {
                ComboBox_usuarios.ForeColor = Color.Blue; //se for o 1 que é admin muda pra azul
            }
            
            else
            {
                ComboBox_usuarios.SelectedValue = frmPrincipal.codigo;
                ComboBox_usuarios.Enabled = false; //se não for admin bloqueia o combo

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                MySqlCommand oComandoSenha = new MySqlCommand();
                oComandoSenha.Connection = frmPrincipal.oConexao;

                oComandoSenha.CommandText = "UPDATE USUARIOS SET SENHA = MD5(@senha) where CODIGO = @CODIGO";

                oComandoSenha.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBox1.Text;
                oComandoSenha.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = ComboBox_usuarios.SelectedValue;

                oComandoSenha.ExecuteNonQuery();
                MessageBox.Show("Troca de senha feita com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("As novas senhas digitadas não são iguais!");
            }
        }
    }
}
