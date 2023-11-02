using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

/*
Crie um programa que solicite o ano de nascimento de uma pessoa, calcule e mostre sua
sua idade atual. Em seguida, mostre se a pessoa é maior ou menor de idade.
*/


namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("---x--- MAIORIDADE ---x---");
            Console.WriteLine();

            Console.Write("Informe o ano de seu nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            int anoatual = DateTime.Now.Year;

            if ((anoatual - ano) > 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
