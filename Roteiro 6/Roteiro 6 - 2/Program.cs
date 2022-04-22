using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Roteiro6
    {
        static void Main(string[] args)
        {
            int x=1, soma=0, y=0;
            while(x!=0){
                Console.WriteLine("Informe um número, quando quiser parar digite 0");
                x =  int.Parse(Console.ReadLine());
                soma += x;
                y++;
            }
            Console.WriteLine("A soma é igual: " +(soma));
            Console.WriteLine("Foram feitas {0} somas", (y-1));
        }
    }
}