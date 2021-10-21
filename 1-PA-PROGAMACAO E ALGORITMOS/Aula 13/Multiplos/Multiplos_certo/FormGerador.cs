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
    public partial class FormGerador : Form
    {
        // Declarações e instanciamentos globais
        
        public FormGerador()
        {
            InitializeComponent();
        }

        private void FormGerador_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ctxMultiPartir_TextChanged(object sender, EventArgs e)
        {
            ltbMultiplos.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int num, i;
            string linha = "";
            if (int.TryParse(ctxPares.Text, out num) && num > 0)
            {
                if (num % 2 != 0)
                    num++;
                i = 1;

                while(i<=1000)
                {
                    linha = linha + " " + num.ToString();
                    if (i % 10 == 0)
                    {
                        ltbpares.Items.Add(linha);
                        linha = "";
                    }
                    num = num + 2;
                    i++;
                }
         
            }
            else MessageBox.Show("Digite apenas número inteiro maior que 0 (zero)!", "Erro no preechimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            ltbpares.Items.Clear();
            ltbImpares.Items.Clear();
            ltbMultiplos.Items.Clear();
            ctxPares.Clear();
            ctxImpares.Clear();
            ctxMultiplo.Clear();
            ctxMultiPartir.Clear();

        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            int num, i;
            string linha = "";

            if (int.TryParse(ctxImpares.Text, out num) && num > 0)
            {
                if (num % 2 == 0)
                    num++;
                i = 1;
                do
                {
                    linha = linha + " " + num.ToString();
                    if (i % 10 == 0)
                    {
                        ltbImpares.Items.Add(linha);
                        linha = "";
                    }
                    num = num + 2;
                    i++;
                    
                } while (i <= 1000);
            }
            else MessageBox.Show("Digite apenas número inteiro maior que 0 (zero)!", "Erro no preechimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void ctxPares_TextChanged(object sender, EventArgs e)
        {
            ltbpares.Items.Clear();
        }

        private void ctxImpares_TextChanged(object sender, EventArgs e)
        {
            ltbImpares.Items.Clear();
        }

        private void ctxMultiplo_TextChanged(object sender, EventArgs e)
        {
            ltbMultiplos.Items.Clear();
        }

        private void btnMultiplos_Click(object sender, EventArgs e)
        {
            int num, i, mult;
            string linha = "";

            if (int.TryParse(ctxMultiPartir.Text, out num) && num > 0 && int.TryParse(ctxMultiplo.Text, out mult) && mult > 0)
            {
                if (num % mult != 0)
                    num = num + (mult - (num % mult));

                for (i=1; i<= 1000; i++)
                {
                    linha = linha + " " + num.ToString();
                    if( i % 10 == 0)
                    {
                        ltbMultiplos.Items.Add(linha);
                        linha = "";
                    }
                    num = num + mult;
                }
            }
            else MessageBox.Show("Digite apenas número inteiro maior que 0 (zero)!", "Erro no preechimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);






        }

        private void LtbPares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
