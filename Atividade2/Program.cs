using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Crie um programa para converter a temperatura de Celsius para Fahrenheit ou vice-versa.
O programa deve mostrar a temperatura convertida. 
*/
namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempconv = 0;
            double temp;
            int tipo;

            Console.WriteLine("---x--- CONVERSOR DE TEMPERATURA ---x---");
            Console.WriteLine();

            Console.Write("Informe a temperatura: ");
            temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Fahrenheit");
            Console.Write("Digite para qual escala você quer converter: ");
            tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1)
            {
                tempconv = (temp - 32) / 1.8;
            }
            else if (tipo == 2)
            {
                tempconv = (temp * 9 / 5) + 32;
            }

            Console.WriteLine();
            Console.WriteLine("A temperatura convertida é: " + tempconv);
        }
    }
}
