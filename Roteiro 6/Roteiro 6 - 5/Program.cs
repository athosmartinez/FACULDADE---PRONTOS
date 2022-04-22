using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char repetir;
            do
            {
                double numero = 1, gasolina = 1, alcool, diesel, gasolina1 = 1, alcool1 = 1, diesel1 = 1, gasolina0 = 100000000, alcool0 = 100000000, diesel0 = 100000000;
                do
                {
                    Console.WriteLine("\nInforme o preço do gasolina:");
                    gasolina = double.Parse(Console.ReadLine());
                    if (gasolina == 0)
                    {
                        continue;
                    }
                    Console.WriteLine("Informe o preço do alcool:");
                    alcool = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o preço do diesel:");
                    diesel = double.Parse(Console.ReadLine());

                    if (gasolina > gasolina1)
                    {
                        gasolina1 = gasolina;
                    }
                    if (alcool > alcool1)
                    {
                        alcool1 = alcool;
                    }
                    if (diesel > diesel1)
                    {
                        diesel1 = diesel;
                    }
                    if (gasolina < gasolina0)
                    {
                        gasolina0 = gasolina;
                    }
                    if (alcool < alcool0)
                    {
                        alcool0 = alcool;
                    }
                    if (diesel < diesel0)
                    {
                        diesel0 = diesel;
                    }


                } while (gasolina != 0);
                Console.WriteLine("\nMaior G:" + gasolina1);
                Console.WriteLine("Maior A:" + alcool1);
                Console.WriteLine("Maior D:" + diesel1);
                Console.WriteLine("Menor G:" + gasolina0);
                Console.WriteLine("Menor A:" + alcool0);
                Console.WriteLine("Menor D:" + diesel0);
                Console.WriteLine("\n Deseja repetir o programa ? (S / N)");
                repetir = Console.ReadKey().KeyChar;

            } while (repetir == 'S' || repetir == 's');
        }
    }
}