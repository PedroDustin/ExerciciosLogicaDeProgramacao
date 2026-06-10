using System;
using System.Collections.Generic;
using System.Text;

//7.Limite de banda: Leia a quantidade de tráfego de rede gerado em GB.
//Se ultrapassar 100 GB, calcule um adicional de R$ 5,00 por GB excedente e exiba o valor da taxa.

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
            string separador = "----------------";

            Console.WriteLine("Digite o valor do tráfego da rede em GB");
            int trafegoEmRede = Convert.ToInt16(Console.ReadLine());

            float taxa = 0;

            if (trafegoEmRede > 100)
            {
                int excedente = trafegoEmRede - 100;
                taxa = excedente * 5;
            }

            Console.WriteLine(separador);

            Console.WriteLine("A taxa por excedente de GB é :" + taxa);
        }
    }
}
