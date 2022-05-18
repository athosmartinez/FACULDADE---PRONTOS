using System;

namespace ex1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int quantidade = 10;

            float[] listaa = new float[quantidade];
            float[] listab = new float[quantidade];
            LeVetor(listaa);
            LeVetor(listab);
            float[] listac = new float[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                if (listaa[i] < listab[i])
                {

                    listac[i] = listaa[i];
                }
                else
                {
                    listac[i] = listab[i];
                }
                Console.WriteLine(listac[i]);
            }
        }
        static void LeVetor(float[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Entre com a nota do aluno [{0}]", i + 1);
                vetor[i] = float.Parse(Console.ReadLine());
            }
        }

    }
}
