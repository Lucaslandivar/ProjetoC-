using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //double largura, comprimento, precoMetroQuadrado, area, preco;

            //Console.WriteLine("Entre com a largura do terreno: ");
            //largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com o comprimento do terreno: ");
            //comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com o preço do metro quadrado: ");
            //precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = largura * comprimento;
            //preco = area * precoMetroQuadrado;

            //Console.WriteLine("Área do terreno: " + area.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Preço do terreno: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            //Console.ReadLine();

            //Console.WriteLine("Hello World!");

            //double R, A, pi = 3.14159;

            //R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //A = pi * R * R;

            //Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            //Console.ReadLine();

            int A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            var SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}