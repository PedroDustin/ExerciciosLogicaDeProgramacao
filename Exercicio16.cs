using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//16.Tensão e Corrente: Leia os valores de tensão (V) e corrente (I).
//Calcule a potência ($P = V * I$). Se a potência for superior a 1000W,//exiba
//"Equipamento de alta potência", senão exiba "Equipamento de baixa potência".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de tensão");
            float tensao = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de tensão");
            float corrente = float.Parse(Console.ReadLine());

            float potencia = tensao * corrente;

            if (potencia > 1000)
            {
                Console.WriteLine("Equipamento de alta potência");
            }
            else
            {
                Console.WriteLine("Equipamento de baixa potência");
            }
        }
    }
}
