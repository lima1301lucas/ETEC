using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fr
{
    public partial class Form1 : Form
    {
        double larg, alt, ar, pe;
        string aa;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Título_Click(object sender, EventArgs e)
        {

        }

        public void LBAltura_Click(object sender, EventArgs e)
        {

            alt = double.Parse(Console.ReadLine());
        }

        public void CTLarg_Click(object sender, EventArgs e)
        {
            larg = double.Parse(Console.ReadLine());
        }

        public void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BTNCalcula_Click(object sender, EventArgs e)
        {

            ar = (double.Parse(CTAltura.Text) * double.Parse(CTLarg.Text));
            CTAr.Text = ar.ToString();
            pe = 2 * (double.Parse(CTAltura.Text) + double.Parse(CTLarg.Text));
            peri.Text = pe.ToString();


        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void CTLarg_TextChanged(object sender, EventArgs e)
        {
            CTAr.Text = "";
            peri.Text = "";
        }

        public void BTNLimpar_Click(object sender, EventArgs e)
        {
            CTAltura.Text = "";
            CTLarg.Text = "";
            CTAr.Text = "";
            peri.Text = "";

        }

        public void CTAr_Click(object sender, EventArgs e)
        {

        }

        private void CTAltura_TextChanged(object sender, EventArgs e)
        {
            CTAr.Text = "";
            peri.Text = "";
        }

        private void peri_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void per_Click(object sender, EventArgs e)
        {

        }

        private void LBLarg_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNLimpar_Click_1(object sender, EventArgs e)
        {
            CTAltura.Text = "";
            CTLarg.Text = "";
            CTAr.Text = "";
            peri.Text = "";
        }

        private void peri_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CTAltura_TextChanged_1(object sender, EventArgs e)
        {
            CTAr.Text = "";
            peri.Text = "";
        }

        private void CTLarg_TextChanged_1(object sender, EventArgs e)
        {
            CTAr.Text = "";
            peri.Text = "";
        }


    }
}