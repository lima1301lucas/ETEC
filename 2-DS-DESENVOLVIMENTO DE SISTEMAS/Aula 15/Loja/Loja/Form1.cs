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

namespace Loja
{
    public partial class Form1 : Form
    {

        public static MySqlConnection oConexao = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            MySqlCommand oComando = new MySqlCommand();
            oComando.Connection = oConexao;
            if (rbProduto.Checked == true)
            {
                 if(txt_nome.Text != "")
                {
                btn_excluir.Enabled = false;
                oComando.CommandText = "INSERT INTO PRODUTOS(PRDNOME, PRDDESCRICAO, PRDCATEGORIA, PRDVLRUNIT, PRDCODEAN, PRDIMAGEM) values (@nome, @descricao, @categoria, @valor, @codean, @imagem)";
                oComando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txt_nome.Text;
                oComando.Parameters.Add("@descricao", MySqlDbType.Text).Value = txt_descricao.Text;
                oComando.Parameters.Add("@categoria", MySqlDbType.Int32).Value = txt_categoria.Value;
                oComando.Parameters.Add("@valor", MySqlDbType.Decimal).Value = txt_valor.Text;
                oComando.Parameters.Add("@codean", MySqlDbType.VarChar).Value = txt_codigobarras.Text;
                oComando.Parameters.Add("@imagem", MySqlDbType.VarChar).Value = "D:\\imagens" + OpenFileDialog.FileName.Substring(OpenFileDialog.FileName.LastIndexOf("\\"));

                try
                {
                    pictureBox1.Image.Save("D:\\imagens" + OpenFileDialog.FileName.Substring(OpenFileDialog.FileName.LastIndexOf("\\")));
                    oComando.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado!");
                    pictureBox1.Image = null;
                    txt_codigobarras.Clear();
                    txt_descricao.Clear();
                    txt_valor.Clear();
                    txt_categoria = null;
                }

                catch (Exception Erro)
                {
                    MessageBox.Show("Não foi possível gravar a imagem");
                    pictureBox1.Image = null;
                    txt_codigobarras.Clear();
                    txt_descricao.Clear();
                    txt_valor.Clear();
                    txt_categoria = null;
                }            
                }
            }

            if (rbCdsCategoria.Checked == true)
            {
                if (txt_nomecategoria.Text != "")
                {
                    btn_excluir.Enabled = false;
                    oComando.CommandText = "INSERT INTO CATEGORIAS(CTGNOME) values (@nomectg)";
                    oComando.Parameters.Add("@nomectg", MySqlDbType.VarChar).Value = txt_nomecategoria.Text;
                    oComando.ExecuteNonQuery();
                    MessageBox.Show("Categoria cadastrada!");
                    
                }

                 if(txt_nomecategoria.Text == "")
                     MessageBox.Show("O nome não foi preenchido.");
            }

            else
            {
                if (rbProduto.Checked == true && txt_nome.Text == "" || pictureBox1.Image == null)
                {
                    MessageBox.Show("O nome e a imagem devem ser preenchidos.");

                }

                if(rbProduto.Checked == false && rbCdsCategoria.Checked == false)
                {
                    MessageBox.Show("Tela de cadastro não selecionada.");
                }
            }

            txt_nome.Clear();
            txt_nomecategoria.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oConexao.ConnectionString = "server=localhost; uid=root; pwd=1234; database=aula; SSLMode=none";
            oConexao.Open();
            //MessageBox.Show("Conectado!");
        }

        private void fnExibir(object sender, EventArgs e)
        {
            pnlProdutos.Visible = rbProduto.Checked;
            pnlCategorias.Visible = rbCdsCategoria.Checked;
           
        }

        private void rbCdsCategoria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
            
            if(OpenFileDialog.FileName != "")
            {
                pictureBox1.Image = Bitmap.FromFile(OpenFileDialog.FileName);
            }
        }
    }
}
