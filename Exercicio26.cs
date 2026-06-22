using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//26.Categoria de projeto: Leia a quantidade de linhas de código de um projeto web.
//Se < 1000 exiba "Pequeno porte", entre 1000 e 5000 exiba "Médio porte", acima de 5000 exiba "Grande porte".
namespace ListaEstruturaDeDecisao
{
    internal class Exercicio26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite quantas linhas de código tem o seu projeto");
            int linhaDeCodigo = Convert.ToInt16(Console.ReadLine());

            if (linhaDeCodigo < 1000)
            {
                Console.WriteLine("Pequeno porte");
            }else if (linhaDeCodigo <= 5000)
            {
                Console.WriteLine("Médio porte");
            }
            if (linhaDeCodigo > 5000)
            {
                Console.WriteLine("Grande porte");
            }
        }
    }
}
