using System;

namespace ex3 
{
//Em uma cidade sabe-se que, em janeiro de um certo ano, não ocorreu temperatura inferior a 15°C, nem superior a 40°C.
//Faça um programa que leia as temperaturas diárias (dos 10 primeiros dias) calcule e imprima:
//a) A menor e a maior temperatura ocorrida
//b) A temperatura média
//c) Em quais dias a temperatura foi inferior a temperatura média.
    internal class Program
    {
        const int qnttemp = 10;
        static void Main(string[] args)
        {
            int menortemp = 0, maiortempo = 0, somatemperatuas = 0, mediatemperaturas = somatemperatuas / 10;
            int[] temperaturas = new int[qnttemp];
            leosdias(temperaturas);

            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (i == 0)
                {
                    menortemp = temperaturas[0];
                    maiortempo = temperaturas[0];
                }
                if (temperaturas[i] < menortemp)
                {
                    menortemp = temperaturas[i];

                }
                else if (temperaturas[i] > maiortempo)
                {
                    maiortempo = temperaturas[i];

                }
            }
            Console.WriteLine("A menor temperatura é: " + menortemp);

            Console.WriteLine("A maior temperatura é: " + maiortempo);

            for (int i = 0; i < qnttemp; i++)
            {
                somatemperatuas += temperaturas[i];
            }

            mediatemperaturas = (somatemperatuas / qnttemp);

            Console.WriteLine("A média da temperaturas é: " + mediatemperaturas);

            menorquemedia(temperaturas, mediatemperaturas);

        }
        static void leosdias(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Dite a temperatura do {0} dia de janeiro:  ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        static void menorquemedia(int[] temp, int media)
        {
            Console.Write("\nA tempaeratura dos dias: ");
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < media)
                    Console.Write((i + 1) + ", ");
            }
            Console.WriteLine("foram abaixo da média.");
        }
    }
}
