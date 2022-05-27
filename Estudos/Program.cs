using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int maior = 0, menor = 999, media = 0, soma = 0;
            int[,] A = new int[4, 4];
            LeMatriz(A);
            SomaMatriz(A, soma);


            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > maior)
                    {
                        maior = A[i, j];
                    }
                    else if (A[i, j] < menor)
                    {
                        menor = A[i, j];
                    }
                }
            Console.WriteLine("A menor é igual " + menor);
            Console.WriteLine("A maior é igual " + maior);
            ImprimeMatriz(A);
        }

        static void ImprimeMatriz(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                Console.Write(A[i, j] + " ");
                Console.WriteLine(); 
            }
        }

        static void LeMatriz(int[,] MatrizA)
        {
            for (int i = 0; i < MatrizA.GetLength(0); i++)
                for (int j = 0; j < MatrizA.GetLength(1); j++)
                {
                    Console.WriteLine("Digite os números da Matriz:");
                    MatrizA[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void SomaMatriz(int[,] MatrizA, int soma)
        {
            soma = 0;
            for (int i = 0; i < MatrizA.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizA.GetLength(1); j++)
                {
                    soma = soma + MatrizA[i, j];
                }
            }
            double media = soma / 16;
            Console.WriteLine("Soma da matriz: " + soma);
            Console.WriteLine("A media é igual: " + media);

        }

    }
}