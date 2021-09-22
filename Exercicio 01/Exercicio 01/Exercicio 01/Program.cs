using System;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, irs, sSocial, salarioFinal;
            Console.WriteLine("Informe o seu salario: ");
            salario = double.Parse(Console.ReadLine());

            irs = salario * 0.15;
            sSocial = salario * 0.12;
            salarioFinal = salario - irs - sSocial;

            Console.WriteLine("IRS: R$" + irs.ToString("f2"));
            Console.WriteLine("Segurança Social: R$" + sSocial.ToString("f2"));
            Console.WriteLine("Salario liquido: R$" + salarioFinal.ToString("f2"));

            Console.ReadKey();
        }
    }
}
