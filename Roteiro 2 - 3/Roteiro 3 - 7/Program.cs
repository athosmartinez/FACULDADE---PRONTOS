using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
              int n1, n2, n3, maior, maior2;
            Console.WriteLine("Digite 3 valores");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            maior = n1;
            else {
                if (n2 > n1 && n2 > n3)
            maior = n2;
            else
                maior=n3;
            }
            if (n1 > n2 && n1 < n3||n1 > n3 && n1 < n2)
            maior2 = n1;
            else {
                if (n2>n1 && n2<n3 || n2>n3 && n2<n1)
                maior2 = n2;
                else
                maior2 = n3;
                 Console.WriteLine(maior+" + "+maior2+" = "+ (maior+maior2));
            }
            

            
 
            

           Console.ReadKey();
           Console.ReadLine();
            


            
           

            

            



        }
    }}
