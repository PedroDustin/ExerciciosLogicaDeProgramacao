using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//28.Tipos de Triângulo: Leia três valores que representam os lados de um triângulo. Se todos forem iguais (Equilátero), se dois forem iguais (Isósceles), se todos forem diferentes (Escaleno).

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado de um triângulo");
            float lado1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado de um triângulo");
            float lado2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado de um triângulo");
            float lado3 = float.Parse(Console.ReadLine());

            if (lado1 == lado2 && (lado2 == lado3))
            {
                Console.WriteLine("Equilátero");
            } else if (lado1 == lado2)
            {
                Console.WriteLine("Isósceles");
            }
            if (lado1 != lado2 && (lado2 != lado3))
            {
                Console.WriteLine("Escaleno");
            }
        }
    }
}
