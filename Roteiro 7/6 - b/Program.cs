using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 21, e = 250, d = 0, soma = 0;
            for (double i = 21; i <= 250; i++)
            {
                d = c/e;
                c = c + 1;
                e = e - 1;
                soma += d;
            }
            Console.WriteLine(soma);

        }
    }
}