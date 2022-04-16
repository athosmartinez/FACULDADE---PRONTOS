using System;

namespace Roteiro3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 1, soma = 0, numero;
            while (i <= 10)
            {
                Console.Write("Número:");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
                i++;
            }
            Console.WriteLine("A soma é igual a {0}", soma);

        }

    }
}



