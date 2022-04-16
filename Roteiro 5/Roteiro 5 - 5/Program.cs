using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Escreva o número");
            i = int.Parse(Console.ReadLine());
            if (i % 2 != 0)
            {
                while (i >= 0)
                {
                    Console.WriteLine(i);
                    i = i - 2;
                }
            }
            else if (i % 2 == 0)
            {
                i = i - 1;
            } while (i >= 0)
            {
                Console.WriteLine(i);
                i = i - 2;
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}