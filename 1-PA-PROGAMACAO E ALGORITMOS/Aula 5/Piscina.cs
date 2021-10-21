using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo da área e o volume de uma piscina com o formato de um paralelogramo");

            double largura;
            double profundidade;
            double comprimento;

            Console.Write("\nDigite o comprimento da sua piscina em metros: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a largura da sua piscina em metros: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a profundidade da sua piscina em metros");
            profundidade = double.Parse(Console.ReadLine());

            Console.Write("\n\n*** Cálculo da área da piscina*** \n\n");

            Console.Write("\nÁrea da piscina: " + (comprimento * largura) + "m²");
            Console.Write("\n");
            Console.Write("\nVolume da piscina: " + (largura*comprimento*profundidade) + "m³");
            Console.Write("\n");
            Console.Write("\nVolume da piscina em litros: " + (largura*comprimento*profundidade*1000));
            Console.Write("\n");
            Console.WriteLine("\nAperte qualquer tecla para sair !");
            Console.ReadKey();
        }
    }
}
