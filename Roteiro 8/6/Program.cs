using System;

namespace ex6 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias, dia = 1, mes = 1, ano = 1900;
            Console.WriteLine("Digite o número de dias corridos:");
            dias = int.Parse(Console.ReadLine());
            WhatDate(ref dia, ref mes, ref ano, ref dias);
        }

        static void WhatDate(ref int d, ref int m, ref int a, ref int ds)
        {
            a = (ds / 365);
            int restoano = ds % 365;
            m = restoano / 30;
            int restomes = restoano % 30;
            d = restomes;
            Console.WriteLine(a);
                if(ds > 0){
                    a += 1900;
                }
                else {
                    a = 1900 +a;
                    m = 12 + m;
                    d = 30 +d;
                }
                Console.WriteLine("dia {0} : Mês {1} : Ano {2}", d, m, a);
        }

    }
}
