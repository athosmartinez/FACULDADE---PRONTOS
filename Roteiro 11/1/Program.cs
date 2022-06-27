using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
                StreamWriter file;
            file = new StreamWriter("Poema.txt");
            Console.WriteLine("Digite um texto para o arquivo: ");
            String text = Console.ReadLine();
            file.WriteLine(text);
            file.Close();
        }
    }
}