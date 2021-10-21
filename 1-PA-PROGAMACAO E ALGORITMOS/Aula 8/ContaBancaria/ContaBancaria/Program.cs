using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhaissaSalvou
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo, saque, deposito;
            int cont = 0, x, y, z,;
            Console.WriteLine("Testando os outros operadores de atribuição\n");
            Console.Write("Informe o saldo inicial: ");
            saldo = double.Parse(Console.ReadLine());
            Console.Write("Informe o saque a ser realizado nesse saldo: ");
            saque = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o depósito a ser realizado nesse saldo: ");
            deposito = double.Parse(Console.ReadLine());
            Console.WriteLine("\nSaldo Inicial: {0:N}:", saldo);
            saldo -= saque;
            Console.WriteLine("Saldo depois do saque {0:N}: {1:N}", deposito, saldo);
            saldo += deposito;
            Console.WriteLine("Saldo depois do depósito {0:N}: {1:N}", deposito, saldo);
            Console.WriteLine("\nValor inicial de cont: {0}", cont);
            cont ++;
            Console.WriteLine("Valor de cont depois do {0}º incremento(cont++): {1}", cont, cont);
            ++cont;
            Console.WriteLine("Valor de cont depois do {0}º incremento(++cont): {1}", cont, cont);
            cont++;
            Console.WriteLine("Valor de cont depois do {0}º incremento(cont++): {1}", cont, cont);
            ++cont;
            Console.WriteLine("Valor de cont deois do {0}º incremento(++cont): {1}", cont,cont);
            cont--;
            Console.WriteLine("Valor de cont depois do {0}º decremento(cont--): {1}", 1, cont);
            --cont;
            Console.WriteLine("Valor de cont depois do {0}º decremento(--cont): {1}", 2, cont);
            cont--;
            Console.WriteLine("Valor de cont depois dio {0}º decremento(cont--): {1}", 3, cont);
            x = 1; y = 1; z = 1;
            Console.WriteLine("\n\nx = {0}; y = {1}; z = {2}", x, y, z);
            Console.WriteLine("Agora usando o prefixo: y = ++x;");
            y = ++x;
            Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
            Console.WriteLine("Agora usando o sufixo: z = x++;");
            z = x++;
            Console.WriteLine("x = {0}; y = {1}; z =");
        }
    }
}
