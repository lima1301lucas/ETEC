using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raio
{
    class Program
    {
        static void Main(string[] args)
        {
            // definição da constante de pi
            const double pi = 3.14159265358979323846264338327950;

            // declaração de variável e atribuição de valor na variável
            double raio = 10;
            double area;

            Console.WriteLine("Cálculo da área de um Circulo\n");
            Console.WriteLine("Fórmula da área de pi = *raio² \n");

            //Math.Pow: exponenciação
            area = pi * Math.Pow(raio, 2); // sem usar o método pow seria: pi * raio* raio;

            Console.WriteLine("Área = {0}" , area);
            Console.WriteLine("Área = {0:N}" , area);   // duas casas decimais
            Console.WriteLine("Área = {0:N5}" , area);  //  cinco casas decimais
            Console.WriteLine("Área = {0:N0}" , area);

            Console.WriteLine("\nAPERTE QUALQUER TECLA PARA FECHAR O PROGRAMA!!!!");
            Console.ReadKey();

        }
    }
}
