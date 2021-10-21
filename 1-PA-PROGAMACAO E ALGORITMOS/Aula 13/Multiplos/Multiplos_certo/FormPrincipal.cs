using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplos_certo
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void calculadoraWindowsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "Calc.Exe";
            process1.Start();
        }

        private void raizEquação2ºGrauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equação objRaiz = new Equação();
            objRaiz.ShowDialog();
        }

        private void rodizioVeicularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRodizio objrodizio = new FormRodizio();
            objrodizio.ShowDialog();
        }

        private void geradorDeNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerador objgerar = new FormGerador();
            objgerar.ShowDialog();

        }

        private void AplicativosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
