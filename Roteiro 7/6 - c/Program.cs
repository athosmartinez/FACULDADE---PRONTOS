using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, d, c = 0, n = 0, soma = 0;
            Console.WriteLine("Digite o valor de N");
            n = double.Parse(Console.ReadLine());
            for (double i = 1; i <= n; i++)
            {
                Console.Write("{0}/{1}", i, Math.Pow(i, 2));
                if (i != n)
                {
                    if (i % 2 == 0)
                        Console.Write(" + ");
                    else
                        Console.Write(" - ");
                }
                soma = i%2==0 ? soma-(double)i/Math.Pow(i, 2) : soma+(double)i/Math.Pow(i, 2);
            }
            Console.WriteLine("\nL = {0:0.00}", soma);
        }
    }
}