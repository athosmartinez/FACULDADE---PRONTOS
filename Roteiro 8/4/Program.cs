using System;

namespace ex4 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas = 0, minutos = 0, segundos = 0;
            Console.WriteLine("Digite os segundos");
            int seg = int.Parse(Console.ReadLine());

            convertsegundos(seg, ref horas, ref minutos, ref segundos);
            Console.WriteLine("As horas são {0}, os minutos são {1} minutos e os segundos são {2}", horas, minutos, segundos);
        }
        static void convertsegundos(int segundos, ref int h, ref int m, ref int s)
        {
            h = segundos / 3600;
            int restoh = segundos%3600;
            m = restoh / 60;
            int restom = restoh % 60;
            s =  restom;



        }
    }
}