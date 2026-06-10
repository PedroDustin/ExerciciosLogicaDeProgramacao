using System;
using System.Collections.Generic;
using System.Text;

//6.Teste de paridade: Leia um número inteiro. Use o operador MOD (resto da divisão) por 2.
//Se o resultado for 0, exiba "O número é par".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numeroInteiro = Convert.ToInt16(Console.ReadLine());

            if (numeroInteiro % 2 == 0)
            {
                Console.WriteLine("O número é par"); 
            }
            else
            {
                Console.WriteLine("O número é impar");
            }
        }
    }
}
