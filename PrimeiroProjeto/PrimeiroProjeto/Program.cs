using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome = Console.ReadLine();
            int Quartos = int.Parse(Console.ReadLine());
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] Vetor = Console.ReadLine().Split(' ');
            string Nome2 = Vetor[0];
            int idade = int.Parse(Vetor[1]);
            double Altura = double.Parse(Vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Quartos: " + Quartos);
            Console.WriteLine("Preço: " + Preco);
            Console.WriteLine("Nome 2: " + Nome2);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + Altura);
        }
    }
}