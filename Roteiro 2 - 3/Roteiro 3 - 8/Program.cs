using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, media;
            Console.WriteLine("Digite as 4 notas:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            media = ((n1 + n2 + n3 + n4) / 4);
            if (media > 60)
            Console.WriteLine("Vou foi aprovado");
                else {
                    Console.WriteLine("Vou foi reprovado");
                }

            
           Console.ReadKey();
           Console.ReadLine();
           


            
           

            

            



        }
    }
}