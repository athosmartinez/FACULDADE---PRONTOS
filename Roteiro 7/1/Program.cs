using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float C = 1, F = 0;
            Console.WriteLine("Digite zero para começar a tabela");
            C = float.Parse(Console.ReadLine());
            for (int i = 1; i > 0 && i < 101; i++)
            {
                F = 9 * C / 5 + 32;
                C = C + 1;
                Console.WriteLine("{0} {1}", C, F);
            }
        }

    }
}