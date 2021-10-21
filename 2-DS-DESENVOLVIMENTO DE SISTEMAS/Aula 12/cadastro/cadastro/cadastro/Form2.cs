using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace cadastro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmdcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdgravar_Click(object sender, EventArgs e)
        {
            MySqlCommand oInstrucaoSQL = new MySqlCommand();

            oInstrucaoSQL.Connection = Form1.oconexao;

            if (lcodigo.Text == "0")
                oInstrucaoSQL.CommandText = "INSERT INTO ALUNOS ( ALNNOME, ALNDTNASC, ALNSEXO, ALNRG, ALNCPF, ALNNOMEMAE, ALNNOMEPAI, ALNDTMATRICULA) VALUE(@nome, @data, @sexo, @rg, @cpf, @nomemae, @nomepai, NOW())";

            else
              
              oInstrucaoSQL.CommandText = "UPDATE ALUNOS SET ALNNOME = @nome, ALNDTNASC = @data, ALNSEXO = @sexo, ALNRG = @rg, ALNCPF = @cpf, ALNNOMEMAE = @nomemae, ALNNOMEPAI = @nomepai WHERE ALNMATRICULA = " + lcodigo.Text;
             
            
            oInstrucaoSQL.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtnome.Text;
            oInstrucaoSQL.Parameters.Add("@data", MySqlDbType.DateTime).Value = Datanasc.Value;
            oInstrucaoSQL.Parameters.Add("@sexo", MySqlDbType.Byte).Value = rdbfemi.Checked;
            oInstrucaoSQL.Parameters.Add("@rg", MySqlDbType.VarChar).Value = txtrg.Text;
            oInstrucaoSQL.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = txtcpf.Text;
            oInstrucaoSQL.Parameters.Add("@nomemae", MySqlDbType.VarChar).Value = txtmae.Text;
            oInstrucaoSQL.Parameters.Add("@nomepai", MySqlDbType.VarChar).Value = txtpai.Text;

            oInstrucaoSQL.ExecuteNonQuery();
            MessageBox.Show("Registro incluido com sucesso!", "Operação realizada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void FnExibir(int codigo)
        {
            if (codigo > 0)
            {
                MySqlCommand oComando = new MySqlCommand();
                MySqlDataReader oDados;
                oComando.Connection = Form1.oconexao;
                oComando.CommandText = "SELECT * FROM ALUNOS WHERE ALNMATRICULA =" + codigo;
                oDados = oComando.ExecuteReader();

                if (oDados.Read())
                {
                    txtnome.Text = oDados.GetString("ALNNOME");
                    Datanasc.Text = oDados.GetString("ALNDTNASC");
                    rdbfemi.Text = oDados.GetString("ALNSEXO");
                    txtrg.Text = oDados.GetString("ALNRG");
                    txtcpf.Text = oDados.GetString("ALNCPF");
                    txtmae.Text = oDados.GetString("ALNNOMEMAE");
                    txtpai.Text = oDados.GetString("ALNNOMEPAI");
                }
                oDados.Close();
            }
            lcodigo.Text = codigo.ToString();
            
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {
            
        } 
    }
}
