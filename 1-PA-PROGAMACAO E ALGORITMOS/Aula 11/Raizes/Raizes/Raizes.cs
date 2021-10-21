using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raizes
{
    public partial class Raizes : Form
    {
        public Raizes()
        {
            InitializeComponent();
        }

        private void Botao_calcular_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2, cx, cy;

            if (double.TryParse(ctx_a.Text, out a) && (a != 0) && double.TryParse(ctx_b.Text, out b) && double.TryParse(ctx_c.Text, out c))
            {

                delta = (Math.Pow(b, 2)) - (4 * a * c);
                ctx_delta.Text = "Δ = " + delta;

                cx = ((-b) / (2 * a));
                cy = ((-delta) / (4 * a));

                ctx_x.Text = "X do vértice = " + cx.ToString("F");
                ctx_y.Text = "Y do vértice = " + cy.ToString("F");




                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                //Sentido da parábola, as raízes e o sentido

                if (delta == 0)
                {
                    ctx_sentido.Text = "Concavidade para cima";
                    ctx_raizes.Text = "Possui uma única raiz real";
                    if (a < 0)
                    {
                        ctx_sentido.Text = "Concavidade para baixo";
                        img_parabola.Image = Properties.Resources._1_eixo_1;
                    }
                    else img_parabola.Image = Properties.Resources._1_eixo;

                    lbl_x1.Text = "X= " + x1.ToString("f");
                }

                else if (delta < 0)
                {
                    ctx_sentido.Text = " Concavidade para cima";
                    ctx_raizes.Text = "Não tem nenhuma raiz real";

                    if (a < 0)
                    {
                        ctx_sentido.Text = "Concavidade para baixo";
                        img_parabola.Image = Properties.Resources.delta_0_1;

                    }
                    else
                    {
                        img_parabola.Image = Properties.Resources.delta_0;
                    }

                }

                else
                {
                    ctx_sentido.Text = "Concavidade para cima";
                    ctx_raizes.Text = "Possui duas raízes reais";

                    if (a < 0)
                    {
                        ctx_sentido.Text = "Concavidade para baixo";
                        img_parabola.Image = Properties.Resources._2_pontos;

                    }
                    else img_parabola.Image = Properties.Resources._2_pontos_1;

                    lbl_x1.Text = "X'= " + x1.ToString("F");
                    lbl_x2.Text = "X''= " + x2.ToString("F");
                }

                lbl_parabola.Text = "Parábola: ";

            }
            else
            {
                if (ctx_a.Text == "0")
                    MessageBox.Show("A=0 não existe equação de 2º grau", "Erro no preenchimento da equação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                    MessageBox.Show("Os valores de A, B e C devem ser numéricos!", "Erro no preenchimento da equação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
        private void Botao_limpar_Click_1(object sender, EventArgs e)
        {
            ctx_a.Text = "";
            ctx_b.Text = "";
            ctx_c.Text = "";
            ctx_delta.Text = "";
            ctx_raizes.Text = "";
            ctx_sentido.Text = "";
            ctx_x.Text = "";
            ctx_y.Text = "";
            lbl_x1.Text = "";
            lbl_x2.Text = "";
            img_parabola.Image = Properties.Resources.Branco;

        }

        private void Botao_encerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ctx_a_TextChanged_1(object sender, EventArgs e)
        {
            ctx_b.Text = "";
            ctx_c.Text = "";
            ctx_delta.Text = "";
            ctx_raizes.Text = "";
            ctx_sentido.Text = "";
            ctx_x.Text = "";
            ctx_y.Text = "";
            lbl_x1.Text = "";
            lbl_x2.Text = "";
            img_parabola.Image = Properties.Resources.Branco;

        }

        private void Ctx_b_TextChanged_1(object sender, EventArgs e)
        {
       
            ctx_delta.Text = "";
            ctx_raizes.Text = "";
            ctx_sentido.Text = "";
            ctx_x.Text = "";
            ctx_y.Text = "";
            lbl_x1.Text = "";
            lbl_x2.Text = "";
            img_parabola.Image = Properties.Resources.Branco;

        }

        private void Ctx_c_TextChanged_1(object sender, EventArgs e)
        {
            ctx_delta.Text = "";
            ctx_raizes.Text = "";
            ctx_sentido.Text = "";
            ctx_x.Text = "";
            ctx_y.Text = "";
            lbl_x1.Text = "";
            lbl_x2.Text = "";
            img_parabola.Image = Properties.Resources.Branco;
        }
    }
}
