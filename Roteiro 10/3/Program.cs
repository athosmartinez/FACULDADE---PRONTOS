using System;

namespace Ex3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] MatrizA = new int[4, 4];
            int[,] MatrizB = new int[4, 4];
            LeMatriz(MatrizA);
            LeMatriz(MatrizB);
            int[,] MatrizC = new int[4, 4];
            SomaMatriz(MatrizA, MatrizB, MatrizC);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("A soma resulta em C:" + MatrizC[i, j]);
                }
            }
        }
        static void LeMatriz(int[,] Matriz)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("[{0},{1}]=", i + 1, j + 1);
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        static void SomaMatriz(int[,] A, int[,] B, int[,] C)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
        }
    }
}