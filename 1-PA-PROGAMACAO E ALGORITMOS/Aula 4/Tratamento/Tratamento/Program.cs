using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "Lucas", sobrenome = "Lima", completo;
            completo = nome + "" + sobrenome;
            Console.WriteLine("\n1)" + nome + sobrenome);

            Console.WriteLine("\n2)" + completo);

            Console.WriteLine("\n3)" + nome + "possui" + nome.Length + "caracteres");

            Console.WriteLine("\n4)" + sobrenome + "possui" + sobrenome.Length + "caracteres");

            Console.WriteLine("\n5)" + completo + "possui" + completo.Length + "caracteres - incluindo espaços em branco");

            Console.WriteLine("\n6)" + nome + "em minusculo" + nome.ToLower());

            Console.WriteLine("\n7)" + nome + "em maiusculo" + nome.ToUpper());

            Console.WriteLine("\n8)" + nome + "eh igual a" + sobrenome + "=" + nome.Equals(sobrenome));

            Console.WriteLine("\n9)" + nome + "substring iniciando na posiçao 2 e pegando 2 caracteres - " + nome.Substring(2, 2));

            Console.Write("\n10)" + nome + "sigla - " + nome.Substring(0, 1));
            Console.Write(\nsobrenome.Substring(0, 1));

            Console.WriteLine("\nESC para sair !");
            Console.ReadKey();


        }
    }
}
