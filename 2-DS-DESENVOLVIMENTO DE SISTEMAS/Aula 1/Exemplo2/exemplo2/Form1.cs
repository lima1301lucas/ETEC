using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            txt3.Text = vScrollBar3.Value.ToString();
            BackColor = Color.FromArgb(vScrollBar3.Value, vScrollBar2.Value, vScrollBar1.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            txt2.Text = vScrollBar2.Value.ToString();
            BackColor = Color.FromArgb(vScrollBar3.Value, vScrollBar2.Value, vScrollBar1.Value);

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            txt_1.Text = vScrollBar1.Value.ToString();
            BackColor = Color.FromArgb(vScrollBar3.Value, vScrollBar2.Value, vScrollBar1.Value);
        }
    }
}
