using System;

namespace Roteiro3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int soma = 0, numero, qt = 1;
            while (soma < 21)
            {
                Console.Write("Insira um número menor do que 13:");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Ainda não acabou");
                Console.WriteLine("{0} números digitados", qt);
                soma += numero;
                qt++;
            }
            if (soma == 21)
            {
                Console.WriteLine("Acabado, soma = 21 – você ganhou.");
            }
            else if (soma > 21)
            {
                Console.WriteLine("Acabou – você perdeu");

            }
        }
    }
}


