using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media2notasif
{
    public partial class btnlim : Form
    {
        public btnlim()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btncalc_Click(object sender, EventArgs e)
        {
            double media;

            media = (double.Parse(ctxn1.Text) + double.Parse(ctxn2.Text)) / 2;

            CtxMediaE.Text = media.ToString();

            if (media >= 6)
            {
                CtxSituacaoE.ForeColor = Color.Green;
                CtxSituacaoE.Text = "Aprovado";
            }
            else
                if (media < 4)
                {
                    CtxSituacaoE.ForeColor = Color.Red;
                    CtxSituacaoE.Text = "Reprovado";
                }

                else 
                { CtxSituacaoE.Text = "Fazer Exame";
                  CtxSituacaoE.ForeColor = Color.Orange;
                }


            CtxMedisS.Text = media.ToString();

            if (media >= 6)
            {
                CtxSituacaoS.ForeColor = Color.Green;
                CtxSituacaoS.Text = "Aprovado";
            }
            if (media < 4)
            {
                CtxSituacaoS.ForeColor = Color.Red;
                CtxSituacaoS.Text = "Reprovado";
            }
              if ((media>= 4) && (media <6))

            {
                CtxSituacaoS.ForeColor = Color.Orange ;
                CtxSituacaoS.Text = "Fazer exame";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CtxSituacaoS.Text = "";
            CtxSituacaoE.Text = "";
            CtxMediaE.Text = "";
            CtxMedisS.Text = "";
            ctxn1.Text = "";
            ctxn2.Text = "";
        }

        private void Btnenc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lbln1_Click(object sender, EventArgs e)
        {

        }

        private void Ctxn1_TextChanged(object sender, EventArgs e)
        {
            CtxSituacaoS.Text = "";
            CtxSituacaoE.Text = "";
            CtxMediaE.Text = "";
            CtxMedisS.Text = "";
        }

        private void Ctxn2_TextChanged(object sender, EventArgs e)
        {
            CtxSituacaoS.Text = "";
            CtxSituacaoE.Text = "";
            CtxMediaE.Text = "";
            CtxMedisS.Text = "";
        }

        private void CtxMediaE_TextChanged(object sender, EventArgs e)
        {

        }

        private void CtxMedisS_TextChanged(object sender, EventArgs e)
        {

        }

        private void CtxSituacaoS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
