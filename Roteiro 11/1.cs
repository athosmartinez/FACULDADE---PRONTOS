using System;
using System.IO;
using System.Globalization;
namespace Roteiro11
{

    class Atividade1
    {

         void Ati1()
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