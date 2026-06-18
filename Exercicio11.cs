using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//11Maior valor: Leia dois números reais diferentes e exiba qual deles é o maior.

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número real");
            float numero1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite um segundo número real");
            float numero2 = float.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro número é o maior");
            }else 
            {
                Console.WriteLine("O segundo número é o maior");
            }
        }
    }
}
