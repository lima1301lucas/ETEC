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
    public partial class frmPrincipal : Form
    {
        public static MySqlConnection oConexao = new MySqlConnection();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fnBuscar(string cNome)
        {
            MySqlDataAdapter oTabela = new MySqlDataAdapter("SELECT CDSCODIGO Matric, CDSNOME Nome, DATE(CDSDTNASC) Nasc, IF(CDSSEXO=0, 'Masc', 'Fem') Sexo FROM CADASTRO WHERE CDSNOME LIKE '%" + cNome + "%'", oConexao);
            DataTable oDados = new DataTable();

            oTabela.Fill(oDados);
            grdDados.DataSource = oDados;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            oConexao.ConnectionString = "server=127.0.0.1; uid=root; database=EXEMPLO; SSLMode=none";
            oConexao.Open();
            fnBuscar("");
        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            new frmIncluir().Show();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            fnBuscar(txtNome.Text);
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (grdDados.SelectedRows.Count>0)
                if (MessageBox.Show("Você tem CERTEZA de que deseja REALMENTE excluir DE VERDADE o registro selecionado?", "Confirmar operação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlCommand oInstrSQL = new MySqlCommand();

                    oInstrSQL.Connection = oConexao;
                    oInstrSQL.CommandText = "DELETE FROM CADASTRO WHERE CDSCODIGO = 0" + grdDados.SelectedRows[0].Cells[0].Value.ToString();

                    oInstrSQL.ExecuteNonQuery();
                    fnBuscar(txtNome.Text);
                }
        }

        private void grdDados_DoubleClick(object sender, EventArgs e)
        {
            if (grdDados.SelectedRows.Count > 0)
            {
                frmIncluir oIncluir = new frmIncluir();
                oIncluir.fnAlteracao(Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value));
                oIncluir.Show();
            }
        }
    }
}
