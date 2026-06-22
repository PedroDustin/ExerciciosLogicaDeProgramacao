using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//25.Desconto por setor: Leia o código do departamento de um produto (1-Hardware, 2-Software, 3-Redes, Outros)
//e aplique um desconto no preço lido: 10% para Hardware, 20% para Software, 15% para Redes e 0% para outros.
namespace ListaEstruturaDeDecisao
{
    internal class Exercicio25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço do produto");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("1-Hardware");
            Console.WriteLine("2-Software");
            Console.WriteLine("3-Redes");
            Console.WriteLine("outros");
            int setor = Convert.ToInt16(Console.ReadLine());

            double precoFinal = 0;

            if (setor == 1)
            {
                precoFinal = preco - (preco * 0.10);
                Console.WriteLine("Desconto de 10% aplicado;" + " " +precoFinal);
            }
            else if (setor == 2)
            {
                precoFinal = preco - (preco * 0.20);
                Console.WriteLine("Desconto de 20% aplicado;" + " " + precoFinal);
            }
            else if (setor == 3)
            {
                precoFinal = preco - (preco * 0.30);
                Console.WriteLine("Desconto de 30% aplicado;" + " " + precoFinal);
            }
            if (setor == 4)
            {
                Console.WriteLine("Sem desconto aplicados");
            }


        }
    }
}
