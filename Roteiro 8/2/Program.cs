using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça uma função que receba um número inteiro positivo como parâmetro,
            //e caso este número seja primo retorne 1, caso contrário retorne 0.
            //Número primo é aquele que só é divisível por 1 e por ele mesmo.

            int n = 0, cont = 0, numero;

            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
            }

            numero = nPrimo(n);

            if (numero == 1)
            {
                Console.WriteLine("É primo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Não é primo");
            }


        }


        public static int nPrimo(int numeroprimo)
        {
            for (int i = 2; i < numeroprimo; i++)
            {
                if (numeroprimo % 1 == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}


