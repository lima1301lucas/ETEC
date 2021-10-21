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
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
        }
        
        public Graphics grafico;

        private void Form1_Load(object sender, EventArgs e)
        {
            Pn_letra.BackgroundImage = new Bitmap(40 ,50);
            grafico = Graphics.FromImage(Pn_letra.BackgroundImage);

        }

        

        private byte[,] FnDesenho(string Letra)
        {
            int frase = txt_valor.Text.Length;


            
            byte[,] Valor = {
                           {0,0,0,0,0},
                           {0,0,0,0,0},
                           {0,0,0,0,0},
                           {0,0,0,0,0},
                           {0,0,0,0,0},
                           {0,0,0,0,0}
                           };

            if (Letra == "A")
            {
                Valor = new byte [,]
                {
                           {0,1,1,1,0},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,1,1,1,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1}
                };
            }

            else if (Letra == "B")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,0},
                           {1,0,0,0,1},
                           {1,1,1,1,0},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,1,1,1,1}
                };
            }

            else if (Letra == "C")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,1,1,1,1}
                };
            }

            else if (Letra == "D")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,0},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,1,1,1,0}
                };
            }

            else if (Letra == "E")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,1,1,1,0},
                           {1,0,0,0,0},
                           {1,1,1,1,1}
                };
            }

            else if (Letra == "F")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,1,1,1,0},
                           {1,0,0,0,0},
                           {1,0,0,0,0}
                };
            }

            else if (Letra == "G")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,0,1,1,1},
                           {1,0,0,0,1},
                           {1,1,1,1,0}
                };
            }

            else if (Letra == "H")
            {
                Valor = new byte[,]
                {
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,1,1,1,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1}
                };
            }

            else if (Letra == "I")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {0,0,1,0,0},
                           {0,0,1,0,0},
                           {0,0,1,0,0},
                           {0,0,1,0,0},
                           {1,1,1,1,1}
                };
            }

            else if (Letra == "J")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {0,0,0,1,0},
                           {0,0,0,1,0},
                           {1,0,0,1,0},
                           {0,1,0,1,0},
                           {0,0,1,1,0}
                };
            }

            else if (Letra == "K")
            {
                Valor = new byte[,]
                {
                           {1,0,0,1,0},
                           {1,0,1,0,0},
                           {1,1,0,0,0},
                           {1,1,0,0,0},
                           {1,0,1,0,0},
                           {1,0,0,1,0}
                };
            }

            else if (Letra == "L")
            {
                Valor = new byte[,]
                {
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,0,0,0,0},
                           {1,1,1,1,0}
                };
            }

            else if (Letra == "M")
            {
                Valor = new byte[,]
                {
                           {1,0,0,0,1},
                           {1,1,0,1,1},
                           {1,0,1,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1}
                };
            }

            else if (Letra == "N")
            {
                Valor = new byte[,]
                {
                           {0,1,1,1,0},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1}
                };
            }

            else if (Letra == "O")
            {
                Valor = new byte[,]
                {
                           {0,1,1,1,0},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {0,1,1,1,0}
                };
            }

            else if (Letra == "P")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,0},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,1,1,1,0},
                           {1,0,0,0,0},
                           {1,0,0,0,0}
                };
            }

            else if (Letra == "Q" || Letra == "q")
            {
                Valor = new byte[,]
                {
                           {0,1,1,1,0},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,1,0},
                           {0,1,1,0,1}
                };
            }

            else if (Letra == "R")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,0},
                           {1,0,0,0,1},
                           {1,1,1,1,0},
                           {1,0,1,0,0},
                           {1,0,0,1,0},
                           {1,0,0,0,1}
                };
            }

            else if (Letra == "S")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {1,0,1,0,0},
                           {1,1,1,1,1},
                           {0,0,0,0,1},
                           {0,0,0,0,1},
                           {1,1,1,1,1}
                };
            }

            else if (Letra == "T")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {0,0,1,0,0},
                           {0,0,1,0,0},
                           {0,0,1,0,0},
                           {0,0,1,0,0},
                           {0,0,1,0,0}
                };
            }

            else if (Letra == "U")
            {
                Valor = new byte[,]
                {
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {0,1,1,1,0}
                };
            }

            else if (Letra == "V")
            {
                Valor = new byte[,]
                {
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {0,1,0,1,0},
                           {0,0,1,0,0}
                };
            }

            else if (Letra == "W")
            {
                Valor = new byte[,]
                {
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {1,0,1,0,1},
                           {1,1,0,1,1},
                           {1,0,0,0,1}
                };
            }


            else if (Letra == "X")
            {
                Valor = new byte[,]
                {
                           {1,0,0,0,1},
                           {0,1,0,1,0},
                           {0,0,1,0,0},
                           {0,0,1,0,0},
                           {0,1,0,1,0},
                           {1,0,0,0,1}
                };
            }

            else if (Letra == "Y")
            {
                Valor = new byte[,]
                {
                           {1,0,0,0,1},
                           {1,0,0,0,1},
                           {0,1,0,1,0},
                           {0,0,1,0,0},
                           {0,0,1,0,0},
                           {0,0,1,0,0}
                };
            }

            else if(Letra == "Z")
            {
                Valor = new byte[,]
                {
                           {1,1,1,1,1},
                           {0,0,0,0,1},
                           {0,0,0,1,0},
                           {0,0,1,0,0},
                           {0,1,0,0,0},
                           {1,1,1,1,1}
                };
            }
            
        return Valor;
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            grafico.Clear(Color.White);
            byte[,] desenho = FnDesenho(txt_valor.Text);
            for (int y = 0; y<6; y++)
            {
                for (int x = 0; x<5; x++)
                {
                    grafico.FillEllipse(new SolidBrush(Color.Black), (x * 5), (y * 5), (desenho[y, x]) * 5, ((desenho[y, x] * 5)));
                }
            }
            Pn_letra.Refresh();
        }

        private void Pn_letra_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
