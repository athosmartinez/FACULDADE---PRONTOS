using System;

namespace Ex4 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somaAeMedia = 0, somaBeMedia = 0;
            int[,] MatrizA = new int[4, 4];
            int[,] MatrizB = new int[4, 4];
            LeMatriz(MatrizA);
            LeMatriz(MatrizB);
            SomaeMediaDentroMatriz(MatrizA, ref somaAeMedia);
            SomaeMediaDentroMatriz(MatrizB, ref somaBeMedia);
            Console.WriteLine("As médias das PRIMEIRA matriz é: " + somaAeMedia/16);
            Console.WriteLine("As médias das SEGUNDA matriz é: " + somaBeMedia/16);
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
        static void SomaeMediaDentroMatriz(int[,] SomaDentro, ref int soma)
        {
            int media;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    soma += SomaDentro[i, j];
                }
            }
            
        }
    }
}