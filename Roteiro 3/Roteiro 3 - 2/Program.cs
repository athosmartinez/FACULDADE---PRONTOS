using System;

namespace Roteiro1diga
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco, novovalor ;
            Console.WriteLine("Entre o valor do produto:");
            preco = float.Parse(Console.ReadLine());
            novovalor = preco - (preco * 10/100);
            Console.WriteLine("Ficou por: " +novovalor);
            



        }
    }
}