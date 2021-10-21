using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O programa a seguir calcula sua média");

            string nome;
            string situacao;
            double nota1;
            double nota2;
            double nota3;
            double media;

            Console.Write("\n\nDigite seu nome: ");
            nome = (Console.ReadLine());


            Console.Write("\nDigite sua 1ª nota {0}: ",nome);
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite sua 2ª nota {0}: ",nome);
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite sua 3ª nota {0}: ",nome);
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("\n\nCálculo das médias\n\n");

            media = (nota1 + nota2 + nota3) / 03;

            Console.Write("\n\nMédia do aluno é = {0:N2} ", media);

            situacao= media < 4 ?"Reprovado":media < 6? "Fazer exame":"Aprovado";
            
            
            
            Console.WriteLine("\n\n**{0}Situação do {1} é: ", situacao,nome);
            


            Console.WriteLine("\n\nAperte qualquer tecla para sair ! ");
            Console.ReadKey();
            
        }
    }
}
