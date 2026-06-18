using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//17.Diferença absoluta: Leia dois números inteiros, A e B. Se A for maior que B,
//calcule e exiba a subtração de A por B. Senão, calcule e exiba a subtração de B por A.

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int A = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite um número inteiro");
            int B = Convert.ToInt16(Console.ReadLine());

            int resultado = 0;

            if (A > B)
            {
                resultado = A - B;
                Console.WriteLine("\nA é maior que B então:" + resultado);
            }
            else
            {
                resultado = B - A;
                Console.WriteLine("\nB é maior que A então:" + resultado);
            }

        }
    }
}
