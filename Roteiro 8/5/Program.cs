using System;

namespace ex5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano, diacontados;
            Console.WriteLine("Dite o dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Dite o mês:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dite o ano:");
            ano = int.Parse(Console.ReadLine());

            comparedata(ref dia, ref mes, ref ano);
        }
        static void comparedata(ref int d, ref int m,ref int a)
        {
            int difano = a - 1900;
            int difmes = difano * 12 + m - 1;
            int difdia = difano * 365 - 1;
            int i = m;
            while (i >= 1)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    difdia += 31;
                }
                else if (i == 2 || i == 4 || i == 6 || i == 9 || i == 11)
                {
                    difdia += 30;
                }
                i--;
            }
            Console.WriteLine("Dia {0} : Mês {1} : Ano {2} ", difdia,difmes, difano);
        }
    }
}

