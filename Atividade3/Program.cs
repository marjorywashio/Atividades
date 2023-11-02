using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
Crie um programa que peça para que o usuário informe uma senha. Depois de informar a senha 
o sistema deve validar se a senha tem mais de 8 caracteres, uma letra maiúscula, uma letra
minúscula e um número. Informe se é válida ou não. 
*/

namespace Atividade3
{
    internal class Program
    {
        static bool Maiuscula(string senha)
        {
            foreach (char c in senha)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        static bool Minuscula(string senha)
        {
            foreach (char c in senha)
            {
                if (char.IsLower(c))
                    return true;
            }
            return false;
        }

        static bool Numero(string senha)
        {
            foreach(char c in senha)
            {
                if (char.IsNumber(c))
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---x--- VALIDAR SENHA ---x---");
            Console.WriteLine();

            Console.Write("Informe sua senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine();

            if (senha.Length > 8 && Maiuscula(senha) && Minuscula(senha) && Numero(senha))
            {
                Console.WriteLine("Senha válida");
            }
            else
            {
                Console.WriteLine("A senha deve conter mais de 8 caracteres, uma letra maiúscula, uma letra minúscula e um número");
            }

            Console.ReadKey();
        }
        
    }
}
