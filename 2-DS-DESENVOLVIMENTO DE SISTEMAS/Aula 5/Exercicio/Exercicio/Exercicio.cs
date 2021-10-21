using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Exercicio : Form
    {
        public Exercicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string FnMes(int NMes)
        {
            string[] vMes = {"Inválido", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            if(NMes > 0 && NMes < 13)
             return vMes[NMes];
             else
             return "invalido";
        }


        private void btn_btn_Click(object sender, EventArgs e)
        {
            txt_mes.Text = FnMes(DateTime.Now.Month);
        }

        private void Trb_m_Scroll(object sender, EventArgs e)
        {
            label1.Text = FnMes(Trb_m.Value);
        }
    }
}
