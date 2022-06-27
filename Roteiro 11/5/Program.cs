using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          StreamReader file;
            file = new StreamReader("mat.txt");
            String line;
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    line = file.ReadLine();
                    int number = int.Parse(line);
                    matriz[i, j] = number;
                }
            }

            imprimeMatriz(matriz);
            file.Close();


            void imprimeMatriz(int[,] M)
            {
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        Console.WriteLine(M[i, j]);
                    }
                }
            }
        }
    }
}