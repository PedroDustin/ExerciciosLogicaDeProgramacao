using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//18.Autenticação básica: Leia um nome de usuário e uma senha (como caractere).
//Se usuário for "admin" e senha for "12345", exiba "Acesso Liberado", senão exiba "Credenciais Inválidas".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite seu usuário");
            string usuario = Console.ReadLine();

            Console.WriteLine("Digite seu usuário");
            string senha= Console.ReadLine();

            if (usuario == "admin" && senha == "1234")
            {
                Console.WriteLine("Acesso liberado");
            }
            else
            {
                Console.WriteLine("Credenciais inválidas");
            }
        }
    }
}
