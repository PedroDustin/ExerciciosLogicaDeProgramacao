using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//30.Multa de trânsito: Leia a velocidade da via e a velocidade do veículo. Se a velocidade do veículo for até o limite, "Sem multa".
//Se ultrapassar em até 20%, "Multa Média". Se ultrapassar entre 21% e 50%, "Multa Grave". Se ultrapassar mais de 50%, "Multa Gravíssima".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio30
    {
        public static void Main()
        {
            Console.WriteLine("Digite o limite da via");
            float limiteVia = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade do veículo");
            float velocidade = float.Parse(Console.ReadLine());

            double excessoVelocidade = ((velocidade - limiteVia) / limiteVia) * 100;

            if (velocidade <= limiteVia)
            {
                Console.WriteLine("Sem multa");
            }
            else if (excessoVelocidade <= 20)
            {
                Console.WriteLine("Multa média");
            }
            else if (excessoVelocidade <= 50)
            {
                Console.WriteLine("Multa grave");
            }
            else
            {
                Console.WriteLine("Multa Gravíssima");
            }
        }
    }
}