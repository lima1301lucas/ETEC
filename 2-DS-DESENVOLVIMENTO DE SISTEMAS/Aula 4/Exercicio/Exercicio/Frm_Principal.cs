using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Secundario Frm_Sec = new Frm_Secundario();
            Frm_Sec.MdiParent = this;
            Frm_Sec.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obj_arquivo.ShowDialog();
            if (Obj_arquivo.FileName != "")
            {
             
                 

            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
