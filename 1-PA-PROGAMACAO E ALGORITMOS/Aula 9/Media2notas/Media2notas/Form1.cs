using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media2notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double media;
            media = (double.Parse(ctxNota1.Text) + double.Parse(ctxNota2.Text)) /2;
            ctxMedia.Text = media.ToString();

            lblSituacao.Text = media < 4 ? "Reprovado" : media < 6 ? "Fazer exame" : "Aprovado";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ctxMedia.Text = "";
            ctxNota1.Text = "";
            ctxNota2.Text = "";
            lblSituacao.Text = "";
        }

        private void ctxNota1_TextChanged(object sender, EventArgs e)
        {
            ctxMedia.Text = "";
            lblSituacao.Text = "";
        }

        private void ctxNota2_TextChanged(object sender, EventArgs e)
        {
            ctxMedia.Text = "";
            lblSituacao.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
