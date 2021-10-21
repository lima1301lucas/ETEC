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
    public partial class FormRodizio : Form
    {
        int placa = -1; //variável global

        public FormRodizio()
        {
            InitializeComponent();
        }

        private void btn_rodizio_Click(object sender, EventArgs e)
        {

            if ((placa > -1) || (int.TryParse(ctx_a.Text, out placa) && placa >= 0 && placa <= 9))
            {
                switch(placa)
                {
                    case 1:
                    case 2:
                        lbl_resultado.Text = "Segunda-feira.";
                        break;

                    case 3:
                    case 4:
                        lbl_resultado.Text = "Terça-feira.";
                        break;

                    case 5:
                    case 6:
                        lbl_resultado.Text = "Quarta-feira.";
                        break;

                    case 7:
                    case 8:
                        lbl_resultado.Text="Quinta-feira.";
                        break;

                    case 9:
                    case 0:
                        lbl_resultado.Text = "Sexta-feira.";
                        break;
                    
                }
            }
            else MessageBox.Show("Final da placa deve ser inteiro entre 0 e 9", "Erro no preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            
           
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            ctx_a.Text="";
            ctx_a.Enabled = true;
            lbl_resultado.Text = "";
            r0.Enabled = true;
            r1.Enabled = true;
            r2.Enabled = true;
            r3.Enabled = true;
            r4.Enabled = true;
            r5.Enabled = true;
            r6.Enabled = true;
            r7.Enabled = true;
            r8.Enabled = true;
            r9.Enabled = true;
            r0.Checked = false;
            r1.Checked = false;
            r2.Checked = false;
            r3.Checked = false;
            r4.Checked = false;
            r5.Checked = false;
            r6.Checked = false;
            r7.Checked = false;
            r8.Checked = false;
            r9.Checked = false;
        }

        private void ctx_placa_TextChanged(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            placa = -1;
            if (ctx_a.Text != "")
            {
                r0.Enabled = false;
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r4.Enabled = false;
                r5.Enabled = false;
                r6.Enabled = false;
                r7.Enabled = false;
                r8.Enabled = false;
                r9.Enabled = false;

            }
        }

        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            placa = 1;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            placa = 2;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R3_CheckedChanged(object sender, EventArgs e)
        {
            placa = 3;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R4_CheckedChanged(object sender, EventArgs e)
        {
            placa = 4;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R5_CheckedChanged(object sender, EventArgs e)
        {
            placa = 5;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R6_CheckedChanged(object sender, EventArgs e)
        {
            placa = 6;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R7_CheckedChanged(object sender, EventArgs e)
        {
            placa = 7;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R8_CheckedChanged(object sender, EventArgs e)
        {
            placa = 8;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R9_CheckedChanged(object sender, EventArgs e)
        {
            placa = 9;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }

        private void R0_CheckedChanged(object sender, EventArgs e)
        {
            placa = 0;
            lbl_resultado.Text = "";
            ctx_a.Enabled = false;
        }
    }
}