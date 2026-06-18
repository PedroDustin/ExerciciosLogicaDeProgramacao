using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//19.Análise de pacotes: Leia a quantidade de pacotes perdidos em uma transmissão.
//Se o valor for diferente de zero, exiba "Transmissão com perdas", senão exiba "Transmissão perfeita".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de pacotes perdidos na transmissão");
            int PacotesPerdido = Convert.ToInt16(Console.ReadLine());

            if (PacotesPerdido != 0)
            {
                Console.WriteLine("Transmissão com perdas");
            }
            else
            {
                Console.WriteLine("Transmissão perfeita");
            }
        }
    }
}
