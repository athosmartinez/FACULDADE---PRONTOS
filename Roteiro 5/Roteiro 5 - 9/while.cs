using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int i=0, x=0, fibonacci=1;

            while (i<8) {
                int y=x;
                x= fibonacci;
                fibonacci= x + y;
                Console.WriteLine("{0}", fibonacci);
                i++;
            } 
        }
    }
}