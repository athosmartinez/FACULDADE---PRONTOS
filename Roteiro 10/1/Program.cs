using System;

namespace Ex1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Matriz = new int[4, 4];
            LeMatriz(Matriz);
            ImprimeMatriz(Matriz);
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
        static void ImprimeMatriz(int[,] Imprimir)
        {
            Console.WriteLine("OLHA A MATRIZ AÍ OH:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Imprimir[i, j] + " \t ");

                }
                Console.WriteLine();
            }
        }
    }
}