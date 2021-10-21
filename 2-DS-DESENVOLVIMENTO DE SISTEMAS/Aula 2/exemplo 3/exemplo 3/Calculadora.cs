using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_3
{
    public partial class Calculadora : Form
    {
        Double n1;
        Char ope;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = 0, re = 0;
            n1 = double.Parse(ctxResult.Text);

            switch (ope)
            {
                case '+': ctxResult.Text = (this.n1 + n1).ToString(); break;
                case '-': ctxResult.Text = (this.n1 - n1).ToString(); break;
                case '*': ctxResult.Text = (this.n1 * n1).ToString(); break;
                case '/': ctxResult.Text = (this.n1 / n1).ToString(); 
                    if (n1 == 0)
                    {
                        MessageBox.Show("Impossível dividir por 0");

                    }
                    else
                        re = this.n1 / n1;
                    ctxResult.Text = re.ToString();
                    break;

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exibenumero(object sender, EventArgs e)
        {
            ctxResult.Text += ((Button)sender).Text;
        }

        private void operacao(object sender, EventArgs e)
        {
            n1 = double.Parse(ctxResult.Text);
            ctxResult.Clear();
            ope = char.Parse(((Button)sender).Text);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ctxResult.Clear();
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            ctxResult.Text = (double.Parse(ctxResult.Text) * -1).ToString();
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            if (ctxResult.Text.IndexOf(',') < 0)
            {
                ctxResult.Text += ',';
            }
        }

    }
}
