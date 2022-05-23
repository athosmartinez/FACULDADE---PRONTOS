using System;

namespace ex2 
{

//Faça um programa que leia um conjunto de números e os guarde em um vetor. Depois conte e imprima quantos números positivos e a seguir imprima estes números. Depois conte e imprima quantos números negativos e quais são eles. ATENÇÃO: os números positivos e negativos podem ser digitados em qualquer ordem, mas devem ser listados separados (os positivos primeiro, os negativos depois).
//Exemplo: foram digitados os números: 10 -5 4 -11 -12 14 17
//O programa deve exibir como resultado:
//Números positivos: 4
//São eles: 10, 4, 14, 17
//Números negativos: 3
//São eles: -5 -11 -12
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
                Console.Write("Os números digitados são " + listaa[i]);
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

            Console.WriteLine("\nSão {0} positivos ", positivos);
            Console.WriteLine("São {0} negativos ", negativos);
            for (int i = 0; i < positivos; i++)
            {
                Console.Write("Os positivos são " + listap[i]);
            }

            for (int i = 0; i < negativos; i++)
            {
                Console.Write("\nOs negativos são " + listan[i]);
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
