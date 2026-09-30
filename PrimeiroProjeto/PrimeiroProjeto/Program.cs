using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            //string s = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Fala brother, " + frase);
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Z: " + z);
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            Console.WriteLine("C: " + c);
        }
    }
}