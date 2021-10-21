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


namespace Exemplo
{
    public partial class frmIncluir : Form
    {
        public frmIncluir()
        {
            InitializeComponent();
        }

        public void fnAlteracao(int nCod)
        {
            if (nCod > 0)
            {
                MySqlCommand oInstrSQL = new MySqlCommand();
                MySqlDataReader oDados;

                oInstrSQL.Connection = frmPrincipal.oConexao;
                oInstrSQL.CommandText = "SELECT * FROM CADASTRO WHERE CDSCODIGO = 0" + nCod.ToString();

                oDados = oInstrSQL.ExecuteReader();

                if (oDados.Read())
                {
                    txtNome.Text = oDados.GetString("CDSNOME");
                    txtData.Value = oDados.GetDateTime("CDSDTNASC");
                    txtCPF.Text = oDados.GetString("CDSNUMCPF");
                    radMasc.Checked = true;
                    radFem.Checked = oDados.GetBoolean("CDSSEXO");
                    lblCodigo.Text = oDados.GetString("CDSCODIGO");
                }

                oDados.Close();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand oInstrucaoSQL = new MySql.Data.MySqlClient.MySqlCommand();

            oInstrucaoSQL.Connection = frmPrincipal.oConexao;
            if (lblCodigo.Text=="0")
                oInstrucaoSQL.CommandText = "INSERT INTO CADASTRO (CDSNOME, CDSDTNASC, CDSNUMCPF, CDSSEXO) VALUES (@NOME, @DTNASC, @CPF, @SEXO)";
            else
                oInstrucaoSQL.CommandText = "UPDATE CADASTRO SET CDSNOME = @NOME, CDSDTNASC = @DTNASC, CDSNUMCPF = @CPF, CDSSEXO = @SEXO WHERE CDSCODIGO = 0" + lblCodigo.Text;

            oInstrucaoSQL.Parameters.Add("@NOME", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txtNome.Text;
            oInstrucaoSQL.Parameters.Add("@DTNASC", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = txtData.Value;
            oInstrucaoSQL.Parameters.Add("@CPF", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txtCPF.Text;
            oInstrucaoSQL.Parameters.Add("@SEXO", MySql.Data.MySqlClient.MySqlDbType.Bit).Value = radFem.Checked;

            oInstrucaoSQL.ExecuteNonQuery();
        }
    }
}
