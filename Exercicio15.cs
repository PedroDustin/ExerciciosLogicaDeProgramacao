using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//15.Saldo de conta em nuvem: Leia o saldo de créditos em uma conta AWS.
//Se o valor for menor que zero, exiba "Serviços suspensos", senão exiba "Serviços ativos".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o salda da conta em nuvem da conta AWS");
            int saldo = Convert.ToInt16(Console.ReadLine());

            if (saldo < 0)
            {
                Console.WriteLine("Serviços suspensos");
            }
            else
            {
                Console.WriteLine("Serviços ativos");
            }
        }
    }
}
