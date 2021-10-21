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
    public partial class frmBloqueiaUsuario : Form
    {
        public frmBloqueiaUsuario()
        {
            InitializeComponent();
        }

        private void fnBuscar()
        {

        }

        private void frmBloqueiaUsuario_Load(object sender, EventArgs e)
        {
            if (frmPrincipal.codigo == 1)
            {
                MySqlDataAdapter oTabela = new MySqlDataAdapter("SELECT CODIGO, LOGIN, BLOQUEIO FROM USUARIOS", frmPrincipal.oConexao);
                DataTable oDados = new DataTable();
                oTabela.Fill(oDados);
                gridUsuarios.DataSource = oDados;

            }

            else
            {
                MessageBox.Show("Você não possui autorização para acessar estas informações!");
            }
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if (gridUsuarios.SelectedRows.Count > 0)
            {
                MySqlCommand Instrucao = new MySqlCommand();
                Instrucao.Connection = frmPrincipal.oConexao;
                
                Instrucao.CommandText = "UPDATE USUARIOS SET BLOQUEIO = @bloqueio WHERE CODIGO=0" +gridUsuarios.SelectedRows[0].Cells[0].Value.ToString() ;
                
                Instrucao.Parameters.Add("@bloqueio", MySqlDbType.Byte).Value = !Convert.ToBoolean(gridUsuarios.SelectedRows[0].Cells[2].Value);
                Instrucao.ExecuteNonQuery();
            }
        }
    }
}
