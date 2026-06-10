using System;
using System.Collections.Generic;
using System.Text;

//3.Módulo de um número: Leia um número inteiro. Se o número for negativo, transforme-o em positivo multiplicando-o por -1 e
//exiba o resultado.

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro negativo");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero < 0)
            {
                numero = numero * -1;
            }
            Console.WriteLine(numero);
        }
    }
}
