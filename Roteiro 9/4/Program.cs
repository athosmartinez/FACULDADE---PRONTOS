using System;

namespace ex4
{

//Faça um programa que defina um vetor de 120 caracteres, incluindo brancos e:
//• Calcule e imprima quantos brancos existem na frase
//• Calcule e imprima quantas vezes aparece a letra P (maiúscula ou minúscula)
//• Dada uma letra qualquer fornecida pelo teclado, imprimir a primeira vez que ela aparece na frase.
    internal class Program
    {
        const int nchar = 120;
        static void Main(string[] args)
        {
            char[] Caract = new char[120];
            contador(Caract);
        }
        static void contador(char[] args)
        {
            int espacos = 0, letrap = 0, letrax = -1;
            string frase;
            char letra;
            Console.WriteLine("Digite sua frase com no máximo 120 caracteres: ");
            frase = Console.ReadLine();

            Console.WriteLine("Agora insira um carácter");
            letra = char.Parse(Console.ReadLine());

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                    espacos++;
                if (frase[i] == 'p' || frase[i] == 'P')
                    letrap++;
                if ((frase[i] == char.ToUpper(letra) || frase[i] == char.ToLower(letra)) && letrax == -1)
                    letrax = i;
            }

            Console.WriteLine("O número de letras P é: " + letrap);
            Console.WriteLine("O número de espaços é: " + espacos);
            Console.WriteLine("O carácter digitado aparece pela primeira vez em: " + letrax);
        }
    }
}
