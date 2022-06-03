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
            int maior = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (MatrizA[i, j] > maior)
                    {
                       maior = MatrizA[i, j];
                    }
                    else if (MatrizB[i, j] > maior)
                    {
                        maior = MatrizB[i, j];
                    }
                }

            }
            Console.WriteLine("Os o maior elemento é: " + maior);
          
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