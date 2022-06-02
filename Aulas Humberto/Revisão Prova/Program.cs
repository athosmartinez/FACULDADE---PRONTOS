using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
    public static void Main(float[] args)
        {
            d[] tempf = new float[100];
            convertemp(tempf);
            Console.WriteLine("C \t F");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("{0} \t {1}", i, tempf);
            }
        }
        static void convertemp(double[] temp)
        {
            for (int i = 0; i <= 100; i++)
            {
                temp[i] = 9 * i / 5 + 32;
            }
        }
    }
}