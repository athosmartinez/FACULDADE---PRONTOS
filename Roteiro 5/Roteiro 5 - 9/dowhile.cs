using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0, x=0, fibonacci=1;

            do {
                int y=x;
                x= fibonacci;
                fibonacci= x + y;
                Console.WriteLine("{0}", fibonacci);
                i++;
            } while(i<8);
        }
    }
}