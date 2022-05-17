using System;

namespace ex3
{
    //Faça uma função que receba três números inteiros como parâmetros, representando horas, minutos e segundos, e retorne o seu valor convertido em segundos.Exemplo: 2h, 40 min e 10 seg = 9.610 segundos
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;
            Console.WriteLine("Informe a(s) hora(s): ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine(" Informe o(s) minutos(s):");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine(" Informe o(s) segundo(s):");
            s = int.Parse(Console.ReadLine());
            s = ConverteEmSegundos(h, m, s);
            Console.WriteLine("Valor em segundos: "+s);
        }
        static int ConverteEmSegundos ( int h, int m, int s)
        {
            s = h * 3600 + m * 60 + s;
            return s;
        }
    }
}