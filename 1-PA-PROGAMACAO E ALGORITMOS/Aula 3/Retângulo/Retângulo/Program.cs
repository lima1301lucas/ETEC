using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retângulo
{
    class Program
    {
        static void Main(string[] args)
        {
//Declaração de variáveis

            double comp, larg;

            //Atribuição de valores 

            comp = 10.5;
            larg = 6.0;

            //Cálculo da àrea
            Console.WriteLine("\nÀrea do retângulo");
            Console.WriteLine (comp + "*" + larg  + "=" + (comp * larg));

            //Cálculo do perímetro
            Console.WriteLine("\nPerímetro do retângulo");
            Console.WriteLine(comp + "*" + larg + "=" + (2* comp + 2* larg));
            Console.WriteLine("\nESC PARA SAIR!");
            Console.ReadKey();
        }
        }
    }

 