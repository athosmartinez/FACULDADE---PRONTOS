using System;

namespace Ex6 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] MatrizD = new int[4, 4];
            int[,] TransportDMatrizC = new int[4, 4];
            LeMatriz(MatrizD);
            ImprimeMatriz(MatrizD);
            Tranporte(MatrizD, TransportDMatrizC);
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
        static void Tranporte(int[,] D, int[,] C)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    C[i, j] = D[j, i];
            ImprimeMatrizTransportada(C);
        }

        static void ImprimeMatrizTransportada(int[,] Imprimir)
        {
            Console.WriteLine("OLHA A MATRIZ TRANSPORTADA AÍ OH:");
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