using System;
using System.Collections.Generic;
using System.Text;

//8. Múltiplos: Leia dois números inteiros. Se o primeiro número for divisível pelo segundo
//(resto da divisão igual a zero), exiba "O primeiro é múltiplo do segundo".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numero1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            if(numero1 % numero2 == 0)
            {
                Console.WriteLine("O primeiro é multiplo do segundo");
            }
        }
    }
}
