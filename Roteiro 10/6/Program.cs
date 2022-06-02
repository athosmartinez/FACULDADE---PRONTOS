using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] MatrizD = new int[4, 2];
            int[,] TransportDMatrizC = new int[2, 4];
            LeMatriz(MatrizD);
            Tranporte(ref MatrizD, ref TransportDMatrizC);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("A matriz fica:", TransportDMatrizC[j, i]);
                }
            }

        }
        static void LeMatriz(int[,] Matriz)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("[{0},{1}]=", i + 1, j + 1);
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Tranporte(ref int[,] D, ref int[,] C)
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 4; j++)
                    C[i, j] = D[j, i];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("A matriz fica:", C[i, j]);
                }
            }
        }

    }
}