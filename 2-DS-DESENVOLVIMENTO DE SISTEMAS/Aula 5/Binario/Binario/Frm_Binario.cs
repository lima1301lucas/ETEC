using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binario
{
    public partial class Frm_Binario : Form
    {
        public Frm_Binario()
        {
            InitializeComponent();
        }

        private string FnBinario (int binario)
        {
            /*string valor = "";

            int dividendo = Convert.ToInt32(numero);

            if (dividendo == 0 || dividendo == 1)
            {
                return Convert.ToString(dividendo);
            }

            else
            {
                while (dividendo > 0)
                {
                    valor += Convert.ToString(dividendo % 2);
                    dividendo = dividendo / 2;
                }
                return InverterString(valor);
            }*/
            return (binario.ToString());
        }
        private void Btn_binario_Click(object sender, EventArgs e)
        {

        }
    }
}
