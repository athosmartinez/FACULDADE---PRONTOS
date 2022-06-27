using System;
using System.IO;
using System.Globalization;

namespace Roteiro11
{
    class Atividade2
    {
        static void Main(string[] args)
        {
            StreamReader file;
            file = new StreamReader("Poema.txt");
            String line;
            do
            {
                line = file.ReadLine();
                Console.WriteLine(line);
            } while (line != null);
            file.Close();
        }
    }
}
