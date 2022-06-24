using System;
using System.IO;
using System.Globalization;
namespace Roteiro11
{

    class Atividade4
    {

        void Ati4()
        {

            StreamWriter file;
            file = new StreamWriter("mat.txt");
            int[,] matriz = new int[3, 3];
            leMatriz(matriz);
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    file.WriteLine(matriz[i, j] + " ");

                }
            }
            file.Close();


            void leMatriz(int[,] M)
            {
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        Console.WriteLine("Digite um número");
                        M[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
    }
}

