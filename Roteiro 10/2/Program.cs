using System;

namespace Ex2 // Note: actual namespace depends on the project name.
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

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (MatrizA[i, j] > MatrizB[i, j])
                    {
                        MatrizC[i, j] = MatrizA[i, j];
                    }
                    else if (MatrizA[i, j] < MatrizB[i, j])
                    {
                        MatrizC[i, j] = MatrizB[i, j];
                    }
                }

            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Os maiores valores são:" + MatrizC[i, j]);
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
    }
}