using System;

namespace Informaçoes_Do_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, dataDeNascimento;
            int peso;
            Console.WriteLine("Entre com o nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine(nome + ", Qual é o seu peso?");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine(nome + ", Qual é a data de Nascimento?");
            dataDeNascimento = Console.ReadLine();

            Console.WriteLine("Meu nome é "+ nome + ", tenho "+ peso + " quilos e nasci em "+ dataDeNascimento);

            Console.ReadLine();

        }
    }
}
