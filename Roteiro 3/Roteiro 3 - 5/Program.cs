using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite um valor para descobrir se ele é divisel por 2 e 7 ao mesmo tempo:");
            n1 = int.Parse(Console.ReadLine());
            if (n1 % 14 == 0)
            Console.WriteLine("O valor é divisivel por 2 e 7 ao mesmo tempo sim!");
            else {
                Console.WriteLine("O valor não é divisivel por 2 e 7 ao mesmo tempo");
            }

            
           Console.ReadKey();
           Console.ReadLine();
           


            
           

            

            



        }
    }
}