using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h,n, somatorio=0;
            n = double.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++){
                h = 1/(double)i;
                somatorio += h;
            }
            Console.WriteLine(somatorio);
        }
    }
}