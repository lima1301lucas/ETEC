using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void carregarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_imagem FImg = new Frm_imagem();
            FImg.MdiParent = this;
            FImg.Show();

            obj_imagem.ShowDialog();
            if (obj_imagem.FileName != "") //Nome do arquivo diferente de arquivo se for vazio ele cancelou 
            {
                BackgroundImage = new Bitmap(obj_imagem.FileName); //bitmap é uma classe
                /**/

            }
        }

        private void limparPlanoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
        }

        private void alterarPlanoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
