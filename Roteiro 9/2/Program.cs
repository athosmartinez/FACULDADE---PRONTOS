using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args){
            
        }
    

        {
            void LeVetor(float[] vetor)
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write("Entre com a nota do aluno [{0}]", i + 1);
                    vetor[i] = float.Parse(Console.ReadLine());
                }
            }
        }
    }
}