using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, maior, menor, res, i;
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            if (n1 < n2)
            {
                maior = n2;
                menor = n1;
            }
            else
            {
                maior = n1;
                menor = n2;
            }
            i = menor;
            do
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
                i++;       
            } 
           
            while (i <= maior);
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}