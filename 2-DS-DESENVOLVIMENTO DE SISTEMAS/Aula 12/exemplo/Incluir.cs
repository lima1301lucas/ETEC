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
    public partial class Incluir : Form
    {
        public Incluir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Incluir_Load(object sender, EventArgs e)
        {
            
        }

        public void exibe(int codigo)
        {
            if (codigo > 0)
            {
                MySqlCommand Comando = new MySqlCommand();
                MySqlDataReader Dados;
                Comando.Connection = Matrícula.oConexao;
                Comando.CommandText = "SELECT * FROM ALUNO WHERE ALNMATRICULA =" + codigo;
                Dados = Comando.ExecuteReader(); //só para select
                
                //read retorna o registro do banco de dados
                if (Dados.Read())
                {
                    //get string associa com a txt pois é texto depende do tipo do valor 
                    txt_nome.Text = Dados.GetString("alnnome");
                    txt_rg.Text = Dados.GetString("alnrg");
                    txt_cpf.Text = Dados.GetString("alncpf");
                    txt_mae.Text = Dados.GetString("alnnomemae");
                    txt_pai.Text = Dados.GetString("alnnoamepai");
                    Feminino.Checked = Dados.GetBoolean("alnsexo");
                    Data_Nasc.Value = Dados.GetDateTime("alndtnasc");
              
                }
                Dados.Close(); //obrigatório independente se veio ou não registro
            }txt_codigo.Text = codigo.ToString();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            MySqlCommand oInstrucao = new MySqlCommand();
            oInstrucao.Connection = Matrícula.oConexao;
            if (txt_codigo.Text == "0")
            {
                oInstrucao.CommandText = "INSERT INTO ALUNO (ALNNOME, ALNDTNASC, ALNSEXO, ALNRG, ALNCPF, ALNNOMEMAE, ALNNOAMEPAI, ALNDTMATRICULA) " +
                    "VALUES (@nome, @data, @sexo, @numrg, @numcpf, @nomemae, @nomepai, NOW())";
            }
            else
            {
                oInstrucao.CommandText = "UPDATE ALUNO SET ALNNOME =@nome, ALNDTNASC =@data, ALNSEXO =@sexo, ALNRG =@numrg, ALNCPF =@numcpf, ALNNOMEMAE =@nomemae, ALNNOAMEPAI =@nomepai, ALNDTMATRICULA=now() WHERE ALNMATRICULA = " + txt_codigo.Text;

                oInstrucao.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txt_nome.Text;
                oInstrucao.Parameters.Add("@data", MySqlDbType.DateTime).Value = Data_Nasc.Value;
                oInstrucao.Parameters.Add("@sexo", MySqlDbType.Byte).Value = Feminino.Checked;
                oInstrucao.Parameters.Add("@numrg", MySqlDbType.VarChar).Value = txt_rg.Text;
                oInstrucao.Parameters.Add("@numcpf", MySqlDbType.VarChar).Value = txt_cpf.Text;
                oInstrucao.Parameters.Add("@nomemae", MySqlDbType.VarChar).Value = txt_mae.Text;
                oInstrucao.Parameters.Add("@nomepai", MySqlDbType.VarChar).Value = txt_pai.Text;


                oInstrucao.ExecuteNonQuery();//execute algo que não seja consulta ou que não retorna dados


                MessageBox.Show("Registro incluido", "Operação concluida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
