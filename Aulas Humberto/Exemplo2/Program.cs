using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const int lista1 = 20;
        const int lista2 = 20;
        void Main(string[] args)
        {
            int[] listaa = new int[lista1];
            int[] listab = new int[lista2];
            numeros(listaa);
        }
        void numeros(int[] listaa)
        {
            for (int i = 0; i <= listaa.Length; i++)
            {
                Console.WriteLine("Digite os numeros da primeira lista:");
                listaa[i] = int.Parse(Console.ReadLine());

            }
            
        }

    }
}