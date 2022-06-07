using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] MatrizA = new int[4, 4];
            LeMatriz(MatrizA);
            ImprimeMatriz(MatrizA);
            ImprimirDiagonal(MatrizA);

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
        static void ImprimirDiagonal(int[,] Matriz)
        {
            Console.WriteLine("Diagonal ai:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(Matriz[i,j] + "\t ");
                    }
                    else { Console.Write("\t "); }

                }
                Console.WriteLine("\t ");
            }
            Console.WriteLine("\t\t ");
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

