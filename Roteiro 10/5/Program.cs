using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SomaDiagonalA = 0, SomaDiagonalC = 0;
            int[,] MatrizA = new int[4, 4];
            int[,] MatrizC = new int[4, 4];
            LeMatriz(MatrizA);
            LeMatriz(MatrizC);
            SomaDiagonalPrincipal(MatrizA, ref SomaDiagonalA);
            SomaDiagonalSecundaria(MatrizC, ref SomaDiagonalC);
            Console.WriteLine("A soma da diagonal A é:" + SomaDiagonalA);
            Console.WriteLine("A soma da diagonal C é:" + SomaDiagonalC);
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
        static void SomaDiagonalPrincipal(int[,] Matriz, ref int soma)
        {

            for (int i = 0; i < 4; i++)
            {
                soma = soma + Matriz[i, i];
            }
        }
        static void SomaDiagonalSecundaria(int[,] Matriz, ref int soma)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i + j) == 3)
                    {
                        {
                            soma = soma + Matriz[i, j];
                        }

                    }
                }
            }
        }
    }
}