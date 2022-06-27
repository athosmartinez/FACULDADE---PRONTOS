using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
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
