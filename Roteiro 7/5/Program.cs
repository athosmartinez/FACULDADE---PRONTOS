using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, P;
            Console.WriteLine("Dite zero para comecar a tabela");
            C = double.Parse(Console.ReadLine());
            for (int i = 1; i > 0 && i < 101; i++){
                    P = C/(double)2.5;
                    C = C + 1;
                    Console.WriteLine("{0} {1}",C, P);
            }
        }
    }
}