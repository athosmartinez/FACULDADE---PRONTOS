using System;

class Program
{
    public static void Main(string[] args)
    {
        float notas, quantidade, i, soma = 0, media;
        Console.WriteLine("Digite o número de alunos:");
        quantidade = float.Parse(Console.ReadLine());
        for (i = 0; i <= quantidade; i++)
        {
            Console.WriteLine("Digite as notas das provas das provas que valiam 10, dos seus alunos:");
            notas = float.Parse(Console.ReadLine());
            soma += notas;

        }
        media = soma / quantidade;
        Console.WriteLine("Sua sala com {0} alunos, teve a media de notas de {1} pontos", quantidade, media);

        if (media >= 6)
        {
            Console.WriteLine("Sua turma poderá assistir filmes essa aula");
        }
        else
        {
            Console.WriteLine("Infelizmente, sua turma não poderá ter essa aula de filmes. Teremos que revisar a matéria");
        }
    }
}