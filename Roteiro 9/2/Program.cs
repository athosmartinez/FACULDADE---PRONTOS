using System;

namespace ex2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade, positivos = 0, negativos = 0;
            Console.WriteLine("Digite a quantidade de números que irá digitar");
            quantidade = int.Parse(Console.ReadLine());
            float[] listaa = new float[quantidade];
            LeVetor(listaa);
            float[] listan = new float[quantidade];
            float[] listap = new float[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(" " + listaa[i]);
            }

            for (int i = 0; i < quantidade; i++)
            {

                if (listaa[i] < 0)
                {
                    listan[negativos] = listaa[i];

                    negativos++;
                }
                else if (listaa[i] > 0)
                {
                    listap[positivos] = listaa[i];
                    positivos++;
                }
            }

            Console.WriteLine("São {0} positivos eles são ", positivos);
            Console.WriteLine("São {0} negativos eles são ", negativos);
            for (int i = 0; i < positivos; i++)
            {
                Console.Write(" " + listap[i]);
            }

            for (int i = 0; i < negativos; i++)
            {
                Console.Write(" " + listan[i]);
            }
        }
        static void LeVetor(float[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("", i + 1);
                vetor[i] = float.Parse(Console.ReadLine());
            }
        }

    }
}
