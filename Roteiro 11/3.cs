using System;
using System.IO;
using System.Globalization;

namespace Roteiro11
{
    class Atividade3
    {
        static void Main(string[] args)
        {
            StreamReader file;
            file = new StreamReader("Poema.txt");
            String line = "";
            int countLine = 0;
            int secondsPause = 40;
            int seconds = 0;
            do
            {
                if (countLine == 20)
                {
                    seconds++;
                    if (seconds == secondsPause)
                    {
                        countLine = 0;
                    }
                }
                else
                {
                    line = file.ReadLine();
                    Console.WriteLine(line);
                    countLine++;
                }
            } while (line != null);
            file.Close();
        }
    }
}
