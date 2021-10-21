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

namespace CRUD
{
    public partial class FrmCrud : Form
    {
        // Declaraçãoda string de conexão de um banco MYSQL
        MySqlConnection objCnx = new MySqlConnection("Data Source =ETEC-JARAGUÁ;Initial Catalog=crud; Integrated Security=True");
        MySqlCommand objCmd = new MySqlCommand();
        MySqlDataReader objDados;
        public FrmCrud()
        {
            InitializeComponent();
        }

        private void carregarlista()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            objCnx.Open();
            objCmd.CommandText = " SELECT * FROM aluno";
            objDados = objCmd.ExecuteReader();
            if (objDados.Read())
            {
                while(objDados.Read())
                {
                    listBox1.Items.Add(objDados[0].ToString());
                    listBox2.Items.Add(objDados[1].ToString());
                }

            }
            objCnx.Close();
        }

        private void FrmCrud_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "server = localhost; Database=crud; User = root; Pwd=1234";
                objCmd.Connection = objCnx;
                objCnx.Open();
                objCnx.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro==> " + erro.Message, "Erro no ADO.NET - form_load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            carregarlista();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;

                tbxRM.Text = listBox1.SelectedItem.ToString();
                tbxNome.Text = listBox2.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void tbxAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (tbxRM.Text != "" & tbxNome.Text != "")
            {
                objCnx.Open();
                objCmd.CommandText = " DELETE FROM aluno WHERE rm='" + tbxRM.Text + "' AND nome ='" + tbxNome.Text + "'";
                objCmd.ExecuteNonQuery();
                objCnx.Close();

                carregarlista();

                tbxRM.Text = "";
                tbxNome.Text = "";
            }

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (tbxRM.Text != "" & tbxNome.Text != "")
            {
                try
                {
                    objCnx.Open();
                    objCmd.CommandText = "INSERT INTO aluno (rm,nome) VALUES ('" + tbxRM.Text + "','" + tbxNome.Text + "')";
                    objCmd.ExecuteNonQuery();
                    objCnx.Close();
                    carregarlista();
                    tbxNome.Text = "";
                    tbxRM.Text = "";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("ERRO==> " + erro.Message, "Erro no ADO.NET - inserir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (tbxRM.Text != "" & tbxNome.Text != "")
            {
                objCnx.Open();
                objCmd.CommandText = "UPDATE aluno SET rm = '" + tbxRM.Text + "' , nome='" + tbxNome.Text + "' WHERE rm = '" + listBox1.SelectedItem.ToString() + "' AND nome = '" + listBox2.SelectedItem.ToString() + "'";
                objCmd.ExecuteNonQuery();
                objCnx.Close();

                carregarlista();
                
                tbxRM.Text="";
                tbxNome.Text="";
            }
        }
    }
}
