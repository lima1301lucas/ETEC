using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("\nEste programa serve para armazenamneto de dados");
        string nome;            
        int idade;
        double peso;

        Console.Write("\nDigite seu nome: ");
        nome = Console.ReadLine();

        Console.Write(nome + ", digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write(nome + ", digite seu peso: ");
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine("\n*** Informações digitadas ***\n");
        Console.WriteLine("{0} tem {1} anos de idade e pesa {2:N3} Kg", nome, idade, peso);

        Console.Write("\nPressione qualquer tecla para sair!");
        Console.ReadLine();
        
        }
    }
}
