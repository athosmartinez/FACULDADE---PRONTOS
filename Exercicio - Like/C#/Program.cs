using System;

class Program
{
    public static void Main(string[] args)
    {
        float notas, quantidade, i, soma = 0, media;
        Console.Write("Digite o número de alunos: ");
        quantidade = float.Parse(Console.ReadLine());
        for (i = 1; i <= quantidade; i++)
        {
            Console.Write("Digite as notas das provas das provas que valiam 10, dos seus alunos: ");
            notas = float.Parse(Console.ReadLine());
            soma += notas;

        }
        media = soma / quantidade;
        Console.WriteLine("Sua teve a media de notas de {0} pontos", media);

        if (media >= 6)
        {
            Console.WriteLine("Sua turma irá ser premiada");
        }
        else
        {
            Console.WriteLine("Infelizmente sua turma não irá ser premiada");
        }
    }
}