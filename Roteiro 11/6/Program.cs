using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader file;
            file = new StreamReader("texto.txt");
            String line;
            int countChar = 0;
            do
            {
                line = file.ReadLine();
                countChar++;
            } while (line != null);
            file.Close();
            file = new StreamReader("texto.txt");
            char[] vetor = new char[countChar];
            float[] percent = new float[countChar];
            int controllerVetor = 0;
            for (int i = 0; i < countChar; i++)
            {
                string line1 = file.ReadLine();
                char character = ' ';
                if (line1 != null)
                {
                    character = (char)line1[0];
                }

                int index = Array.IndexOf(vetor, character);

                if (character != ' ')
                {
                    if (
                        !Array.Exists(
                            vetor,
                            element => element == character || element == char.ToUpper(character)
                        )
                    )
                    {
                        vetor[controllerVetor] = character;
                        percent[controllerVetor] = 1;

                        controllerVetor++;
                    }
                    else
                    {
                        percent[index] += 1;
                    }
                }
            }
            float[] percentValue = new float[percent.GetLength(0)];

            for (int i = 0; i < percent.GetLength(0); i++)
            {
                percentValue[i] = (float)(percent[i] / countChar);
            }
            Array.Sort(percentValue);

            for (int i = 0; i < percentValue.GetLength(0); i++)
            {
                Console.WriteLine(
                    "Letra: "
                        + vetor[i]
                        + " \t Quantidade: "
                        + percent[i]
                        + " \t Porcentagem: "
                        + percentValue[i] * 100
                );
            }
            file.Close();
        }
    }
}
