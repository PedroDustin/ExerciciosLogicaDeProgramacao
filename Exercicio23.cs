using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//23.Identificação de portas de rede: Leia o número de uma porta. Se for 80, exiba "HTTP". Se for 443, exiba "HTTPS". Se for 22, exiba "SSH". Senão, exiba "Serviço desconhecido ou não padrão".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio23
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da porta");
            int numeroPorta = Convert.ToInt16(Console.ReadLine());

            if (numeroPorta == 80)
            {
                Console.WriteLine("HTTP");
            }else if (numeroPorta == 443)
            {
                Console.WriteLine("HTTPS");
            }
            if (numeroPorta == 22)
            {
                Console.WriteLine("Serviço desconhecido ou não padrão");
            }
        }
    }
}
