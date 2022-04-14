using System;

namespace Roteiro3
{
    class Program
    {
        static void Main(string[] args)
        {
            double horas,salario_hora, bruto, liquido_medio, liquido_grande;
            Console.WriteLine("Digite suas horas trabalhadas e quanto você recebe por hora (no dia)");
            horas = double.Parse(Console.ReadLine());
            salario_hora = double.Parse(Console.ReadLine());
            bruto = (salario_hora * horas);
            liquido_medio = (bruto - (bruto* 0.1));
            liquido_grande = (bruto - (bruto * 0.2));
            if (bruto < 350)
            Console.WriteLine("O seu salário liquido é {0}", bruto);
            else
            {
                if (bruto > 350 && bruto < 1000)
                Console.WriteLine("O seu salário liquido é {0}", liquido_medio);
            else
                if (bruto > 1000)
                Console.WriteLine("O seu salário liquido é {0}", liquido_grande);
                
            }
           
            
           Console.ReadKey();
           Console.ReadLine();
           


            
           

            

            



        }
    }
}