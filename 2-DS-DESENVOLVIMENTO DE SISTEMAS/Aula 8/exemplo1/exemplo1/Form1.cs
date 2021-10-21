using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] FnRetornoVetor(int nTipo)
        {
            int[] nRetorno = { 0, 0, 0 };

            if (nTipo == 1)
            {
                nRetorno[0] = DateTime.Now.Day;
                nRetorno[1] = DateTime.Now.Month;
                nRetorno[2] = DateTime.Now.Year;
            }

            if (nTipo == 2)
            {
                nRetorno[0] = DateTime.Now.Hour;
                nRetorno[1] = DateTime.Now.Minute;
                nRetorno[2] = DateTime.Now.Second;
            }

            return nRetorno;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            lbl_um.Text = FnRetornoVetor(1)[0].ToString();
            lbl_dois.Text = FnRetornoVetor(1)[1].ToString();
            lbl_tres.Text = FnRetornoVetor(1)[2].ToString();
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            lbl_um.Text = FnRetornoVetor(2)[0].ToString();
            lbl_dois.Text = FnRetornoVetor(2)[1].ToString();
            lbl_tres.Text = FnRetornoVetor(2)[2].ToString();
        }

        }
    }

