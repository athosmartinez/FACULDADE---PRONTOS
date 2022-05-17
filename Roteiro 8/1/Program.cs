using System;

namespace ex1 // Note: actual namespace depends on the project name.
{
    //Faça um programa que contenha uma função que receba dois números inteiros como parâmetro de entrada e leia um valor do teclado que esteja entre os dois parâmetros passados. A função deve retornar o número correto para o programa principal e este deve imprimir o valor lido.//
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                int dia, mes;
                Console.WriteLine("Informe o dia entre 1 e 31: ");
                dia = le_no_intervalo(1, 31);
                Console.WriteLine("Informe o mes entre 1 e 12: ");
                mes = le_no_intervalo(1, 12);
                Console.WriteLine("Data: {0}/{1}", dia, mes);
            }

        }

        static int le_no_intervalo(int a, int b)

        {

            int c;
            do
            {
                Console.WriteLine("Informe um valor:");
                c = int.Parse(Console.ReadLine());

            } while (c < a || c > b);
            return c;

        }
    }
}