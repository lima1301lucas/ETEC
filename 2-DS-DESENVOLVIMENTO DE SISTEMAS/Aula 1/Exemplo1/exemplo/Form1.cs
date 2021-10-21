using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblposy_Click(object sender, EventArgs e)
        {

        }

        private void lblposx_Click(object sender, EventArgs e)
        {

        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblposx.Text = e.X.ToString();
            lblposy.Text = e.Y.ToString();
            //onde está o indicador do mouse
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           /* lblposx.Text = e.X.ToString();  não é possível utilizar essas propiedades no evento click*/
           /* lblposy.Text = e.Y.ToString(); /* não é possível utilizar essas propiedades no evento click*/
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Text = e.X.ToString() + ":" + e.Y.ToString(); // Coloca a posição x e y no título do formulário
        }
    }
}
