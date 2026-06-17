using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


//9.Idade mínima: Leia o ano de nascimento de um usuário e o ano atual.
//Se a diferença for maior ou igual a 18, exiba "Maior de idade".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu ano de nascimento");
            int DataNascimento = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o ano atual");
            int DataAtual = Convert.ToInt16(Console.ReadLine());

            if(DataNascimento - DataAtual <= 18)
            {
                Console.WriteLine("Maior de idade");
            }
        }
    }
}