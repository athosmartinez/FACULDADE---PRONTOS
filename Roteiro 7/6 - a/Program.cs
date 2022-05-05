using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d, c = 1, e, somatorio = 0;

            for (int i = 1; i <= 50; i++)
            {
                d = c/(double)i;
                c = c + 2;
                somatorio += d;
            }
            
            Console.WriteLine(somatorio);
        }
    }
}