using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//22.Sinal do número: Leia um número inteiro.Verifique e exiba se ele é Positivo, Negativo ou Zero.

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            if (numero1 < 0)
            {
                Console.WriteLine("Número negativo");
            }else if (numero1 == 0)
            {
                Console.WriteLine("Número 0");
            }
            if (numero1 > 0)
            {
                Console.WriteLine("Número positivo");
            }
        }
    }
}
