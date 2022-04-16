using System;

namespace Roteiro3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number, i = 1;
            Console.WriteLine("Escreva o numero:");
            number = int.Parse(Console.ReadLine());
            while (number > 1)
            {
                
                i = i * number;
                number = number - 1;
                
            }
            i--;
            i++;
            Console.WriteLine("O número fatorial é: {0}", i);
        }
    }
}



