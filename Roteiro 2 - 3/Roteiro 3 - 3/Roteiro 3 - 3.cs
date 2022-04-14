using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite um valor:");
            n1 = double.Parse(Console.ReadLine());
            if (n1 % 2 == 0) {
            Console.WriteLine("O número é par.");
            }
            else 
            {
                Console.WriteLine("O número é impar.");
                
            }
            
           Console.ReadKey();
           Console.ReadLine();
           


            
           

            

            



        }
    }
}
