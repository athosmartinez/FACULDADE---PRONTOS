using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double cos, sen;
            for (i=0; i <= 360; i=i+15) {
                cos = Math.Cos((double)i);
                sen = Math.Sin((double)i);
                Console.WriteLine("angulo=" +i+"cos="+cos);
                Console.WriteLine("angulo=" +i+"sen="+sen);
            }
        }
    }
}