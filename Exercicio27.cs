using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//27.Status de Load Balancer: Leia a carga de processamento de um cluster (0 a 100%). Até 40% (Ocioso), 41% a 70% (Estável), 71% a 90% (Atenção), > 90% (Crítico - escalar novo nó).
namespace ListaEstruturaDeDecisao
{
    internal class Exercicio27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a carga de processament de seu cluster");
            int cluster = Convert.ToInt16(Console.ReadLine());

            if (cluster <= 40)
            {
                Console.WriteLine("Ocioso");
            }else if (cluster <= 70)
            {
                Console.WriteLine("Estável");
            }else if (cluster <= 90)
            {
                Console.WriteLine("Atenção");
            }
            if (cluster > 90)
            {
                Console.WriteLine("Crítico - escalar novo nó");
            }
        }
    }
}
