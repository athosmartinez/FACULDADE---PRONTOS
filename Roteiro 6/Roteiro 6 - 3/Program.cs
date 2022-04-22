using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Roteiro6
    {
        static void Main(String[] args) // Programa para Calcular fatorial
        {
            int N , Cont = 1, Fat = 1;
            char repetir;
            do
            {
                Console.WriteLine("EXEMPLO PARA CALCULAR FATORIAL DE N");
                Console.WriteLine("Entre com um valor para cálculo do fatorial: ");
                N = int.Parse(Console.ReadLine());
                if (N >= 0)
                {
                    Cont=N;
                    
                   while(Cont>0){
                       Fat *= Cont;
                        Cont--;
                       
                   }
                    Console.WriteLine("O fatorial de {0} é {1}", N, Fat);
                    Fat=1;
                }
                else Console.WriteLine("Não posso calcular fatorial de número negativo");
                Console.WriteLine("\n Deseja repetir o programa ? (S / N)");
                repetir = Console.ReadKey().KeyChar;
            } while (repetir == 'S' || repetir == 's');
        }

    }
    
}