using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//20.Desconto de material didático: Leia o valor total da compra de livros. Se o valor passar de R$ 200.00,
//aplique um desconto de 10% e exiba o novo valor.
//Senão, exiba o valor original informando que não houve desconto.

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor total das compras");
            int ValorTotal = Convert.ToInt16(Console.ReadLine());

            float desconto = ValorTotal / 10 ;

            if (ValorTotal > 200 )
            {
                Console.WriteLine("Valor maior que 200, desconto aplicado" + " " + (desconto + ValorTotal));
            }
        }
    }
}
