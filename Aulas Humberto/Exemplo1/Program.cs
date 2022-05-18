using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        void Main(string[] args)
        {
            int[] numeros = new int[200];

            lenumeros(numeros);
        }
        void lenumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite os números:", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
                
            }
        }
    }
}