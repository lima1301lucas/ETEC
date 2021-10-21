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
    public partial class Form1 : Form
    {
        public static MySqlConnection oconexao = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }
        private void FnPesquisa(string cnome)
        {
            MySqlDataAdapter oTabela = new MySqlDataAdapter("SELECT ALNMATRICULA Matricula, ALNNOME nome, ALNDTNASC DtNasc, ALNNOMEMAE Mae, ALNNOMEPAI Pai FROM ALUNOS WHERE ALNNOME LIKE '%" + cnome + "%'", oconexao);
            DataTable oDados = new DataTable();

            oTabela.Fill(oDados);
            dt1.DataSource = oDados;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oconexao.ConnectionString = "Server=127.0.0.1; uid=root; sslmode=none; Database=EXEMPLO_2DS";
            oconexao.Open();

            FnPesquisa("");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FnPesquisa(txt1.Text);
        }

        private void cmdincluir_Click(object sender, EventArgs e)
        {
            Form2 incluir = new Form2();
            incluir.Show();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (dt1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir este campo", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    MySqlCommand intrucao = new MySqlCommand();
                    intrucao.Connection = oconexao;
                    intrucao.CommandText = "DELETE FROM ALUNOS WHERE ALNMATRICULA = " + dt1.SelectedRows[0].Cells[0].Value;
                    intrucao.ExecuteNonQuery();
                }
            }
        }

        private void dt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt1_DoubleClick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FnExibir(Convert.ToInt32( dt1.SelectedRows[0].Cells[0].Value));

        }
    }
}
