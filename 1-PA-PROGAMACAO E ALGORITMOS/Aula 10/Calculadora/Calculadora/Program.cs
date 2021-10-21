using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            int resultado = 0;



            Console.WriteLine("\nCalculadora\n");

            Console.Write("Digite o primeiro numero:");

            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero:");

            num2 = double.Parse(Console.ReadLine());

            {
                Console.WriteLine("\n\n\n");

                Console.WriteLine("Para somar digite 1");

                Console.WriteLine("Para subtrair digite 2");

                Console.WriteLine("Para dividir digite 3");

                Console.WriteLine("Para multiplicar digite 4");



                resultado = int.Parse(Console.ReadLine());

                if (resultado == 1)

                {

                    Console.WriteLine("Soma = {0}", num1 + num2);

                }

                if (resultado == 2)

                {

                    Console.WriteLine("Subtração = {0}", num1 - num2);

                }

                if (resultado == 3)

                {

                    Console.WriteLine("Divisão = {0}", num1 / num2);

                }

                if (resultado == 4)

                {

                    Console.WriteLine("Multiplicação = {0}", num1 * num2);

                }

                Console.WriteLine("\n\nDigite qualquer tecla para sair !");
                Console.ReadLine();

            }

        }

    }

}