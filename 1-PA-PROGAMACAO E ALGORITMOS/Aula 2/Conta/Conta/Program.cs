using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {//início Main
         //Declaração de variáveis
        int a, b, total;
        //Atribuição de valores
        a = 10;
        b = 3;
        /*Concatenação de valores a serem exibidos na tela
Calculo da operação sendo realizado entre parênteses */
        Console.WriteLine(a + " + " + b + " = " + (a + b));
        //Resultado do cálculo da operação sendo atribuído em uma variável
total = a - b;
Console.WriteLine(a + " - " + b + " = " + total);
Console.WriteLine(a + " * " + b + " = " + (a * b));
Console.WriteLine(a + " / " + b + " = " + (a / b));
Console.WriteLine(a + " % " + b + " = " + (a % b));
Console.Write("\nAPERTE QUALQUER TECLA PARA ENCERRAR!POR FAVOR!!!!!!!!!!");
Console.ReadKey(); //Instução utilizada para dar uma pausa para visualização
} //fim Main
} //fim class
} //fim namespace




