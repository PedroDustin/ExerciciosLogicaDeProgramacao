using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//14.Par ou Ímpar: Leia um número inteiro.
//Se o resto da divisão por 2 for zero, exiba "Par", senão exiba "Ímpar".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}
