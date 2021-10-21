using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_médias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O programa a seguir calcula sua média");

            string nome;
            string verdade = "Aprovado", falso = "Reprovado";
            double nota1;
            double nota2;
            double nota3;
            double media;

            Console.Write("\n\nDigite seu nome: ");
            nome = (Console.ReadLine());


            Console.Write("\nDigite sua 1ª nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite sua 2ª nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite sua 3ª nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("\n\nCálculo das médias\n\n");

            media = (nota1 + nota2 + nota3) /03; 

            Console.Write("\n\nMédia do aluno é = {0:N2} ", media);
            Console.WriteLine("\n\n**Situação do aluno**\n");
            Console.WriteLine(media >= 6 ? verdade : falso);
          

            Console.WriteLine("\n\nAperte qualquer tecla para sair ! ");
            Console.ReadKey();
            
        }
    }
}
