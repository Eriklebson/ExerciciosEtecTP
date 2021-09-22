using System;

namespace AulaTP31_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resultado;
            Console.WriteLine("=====Taboada=====");
            Console.WriteLine("Escolha o valor que deseja saber a taboada: ");
            n1 = int.Parse(Console.ReadLine());


            for (int n2 = 1; n2 <= 10; n2++)
            {
                resultado = n1 * n2;
                Console.WriteLine(n1 + " * " + n2 + " = " + resultado);
            }
            Console.ReadKey();

        }
    }
}