using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, soma;
            Console.WriteLine("Informe o primeiro numero:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro numero:");
            n3 = double.Parse(Console.ReadLine());

            soma = n1 + n2 + n3;

            Console.WriteLine("A soma dos 3 valores é: " + soma);
            
            Console.ReadKey();
        }
    }
}
