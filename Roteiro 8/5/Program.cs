using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            Console.WriteLine("Dite o dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Dite o mês:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dite o ano:");
            ano = int.Parse(Console.ReadLine());
        }
    }
}