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
    public partial class Frm_Secundario : Form
    {
        public Frm_Secundario()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obj_cor.ShowDialog();
            Obj_Txt.SelectionColor = Obj_cor.Color;
        }

        private void fundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obj_cor.ShowDialog();
            Obj_Txt.SelectionBackColor = Obj_cor.Color;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, Obj_Txt.SelectedText);
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obj_Txt.SelectAll();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                Obj_SaveFileDialog.ShowDialog();

            if(Obj_SaveFileDialog.FileName != "")
            {
                if (Obj_SaveFileDialog.FilterIndex == 1) ;

            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Obj_Txt.SelectedText = Clipboard.GetText();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, Obj_Txt.SelectedText);
            Obj_Txt.SelectedText = " ";
        }

        private void alterarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj_fonte.ShowDialog();
            Obj_Txt.SelectionFont = obj_fonte.Font;
        }

        private void Frm_Secundario_Load(object sender, EventArgs e)
        {

        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obj_SaveFileDialog.ShowDialog();

            if (Obj_SaveFileDialog.FileName != "")
            {
                Obj_Txt.SaveFile(Obj_SaveFileDialog.FileName);
            }
            else
            {
                Obj_SaveFileDialog.FileName = Text;
                Text = Obj_SaveFileDialog.FileName;
            }
        }



    }
}
