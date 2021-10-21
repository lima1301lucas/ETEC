using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ctx_texto.Text, "O que você digitou: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctx_texto_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void ctx_texto_KeyUp(object sender, KeyEventArgs e)
        {
            lblqtde.Text = ctx_texto.Text.Length.ToString();
        }
    }
}
