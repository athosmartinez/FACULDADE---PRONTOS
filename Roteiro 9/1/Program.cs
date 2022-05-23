using System;

namespace ex1
{

//Declare na função main() dois vetores de inteiros A e B. Usando a função acima, ler dois conjuntos de 10 números, colocando cada conj em um vetor. Depois prencha um terceiro vetor C[] sendo que cada posição de C[] deverá correponder ao menor valor correspondente às respectivas posições nos vetores A[] e B[]. Finalmente imprima o resultado de C[].
//Exemplo:
//Informe primeiro conjunto: 5 10 15 20 25 30 35 40 45 50
//Informe segundo conjunto: 1 2 3 4 5 6 7 8 9 10
//Resultado: 6 12 18 24 30 36 42 48 54 60
    internal class Program
    {
        static void Main(string[] args)
        {
            const int quantidade = 10;

            float[] listaa = new float[quantidade];
            float[] listab = new float[quantidade];
            LeVetor(listaa);
            LeVetor(listab);
            float[] listac = new float[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                if (listaa[i] < listab[i])
                {

                    listac[i] = listaa[i];
                }
                else
                {
                    listac[i] = listab[i];
                }
                Console.WriteLine(listac[i]);
            }
        }
        static void LeVetor(float[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Entre com a nota do aluno [{0}]", i + 1);
                vetor[i] = float.Parse(Console.ReadLine());
            }
        }

    }
}
