using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmSecundario().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmTerciario().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmQuartairo().Show();
        }
    }
}
