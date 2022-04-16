using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
          int n1, i = 1;
          do
          {
              n1 =  int.Parse(Console.ReadLine());
          } while (n1<0);
          while (i<n1)
          {
              if (n1 % i == 0)
              {
                  Console.WriteLine(i);
              }i++;
          }

            
            
            
          
        








            Console.ReadKey();
            Console.ReadLine();












        }
    }
}