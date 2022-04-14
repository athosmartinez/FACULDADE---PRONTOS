using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Digite 3 valores");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            Console.WriteLine("O maior é o {0}", n1);
            else {
                if (n2 > n1 && n2 > n3)
            Console.WriteLine("O maior é o {0}", n2);
            else
                if (n3 > n1 && n3 > n2)
            Console.WriteLine("O maior é o {0}", n3);
            }

            
           Console.ReadKey();
           Console.ReadLine();
           


            
           

            

            



        }
    }
}