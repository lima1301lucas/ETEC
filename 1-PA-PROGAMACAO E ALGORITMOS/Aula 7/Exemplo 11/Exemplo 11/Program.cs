using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 2;  

            Console.WriteLine("Valores da inicialização das variáveis");
            Console.WriteLine("num1 = {0} e num2 = {1}", num1, num2);

            num1 += num2; // Mesma coisa que num1 = num1 + num2

            Console.WriteLine();

            Console.WriteLine("Valores da após a operação num1 += num2 ");
            Console.WriteLine("num1 = {0} e num2 = {1}", num1, num2);

            num1 = 10;
            1++;

            num2 = 2;
            1--;
            
            Console.WriteLine("Valores da após a operação 1++ e 1-- ");
            Console.WriteLine("num1 = {0} e num2 = {1}", num1, num2);

            Console.WriteLine("Aperte qualquer tecla para sair!");
            Console.ReadKey();


        }
    }
}
