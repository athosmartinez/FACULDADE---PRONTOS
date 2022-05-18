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

            Console.WriteLine("Insira um número");
            int a = int.Parse(Console.ReadLine());
            if (Primo(a) == 1)
                Console.WriteLine("É primo");
            else
                Console.WriteLine("Não é primo");


        }


        public static int Primo(int n)
        {
            int count = 0;
            for (int i = n; i >= 2; i--)
            {
                if (n % i == 0)
                    count++;
            }

            if (count == 1)
                return 1;
            else
                return 0;
        }

    }
}



        
