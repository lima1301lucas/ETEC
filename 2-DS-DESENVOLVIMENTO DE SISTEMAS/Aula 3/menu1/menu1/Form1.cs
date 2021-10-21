using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mudarCorDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj_color.ShowDialog();
            BackColor = obj_color.Color;
        }

        private void mudarPlanoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj_arquivo.ShowDialog();
            if (obj_arquivo.FileName != "") //Nome do arquivo diferente de arquivo se for vazio ele cancelou 
            {
                BackgroundImage = new Bitmap(obj_arquivo.FileName); //bitmap é uma classe
                /**/

            }
            
        }

        private void nenhumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.None;
        }

        private void ladoALadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Tile;
        }

        private void centralizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Center;
        }

        private void esticadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void redimensionadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void limparPlanoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void obj_arquivo_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
