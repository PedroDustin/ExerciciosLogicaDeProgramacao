using System;
using System.Collections.Generic;
using System.Text;

//2.MonitorArial Boldamento de CPU: Leia a taxa de uso da CPU de um servidor em porcentagem. Se o valor ultrapassar 85%,
//exiba "Alerta: Sobrecarga no servidor".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a taxa de uso da sua CPU:");
            float TaxaDeUso = float.Parse(Console.ReadLine());

            if (TaxaDeUso > 85)
            {
                Console.WriteLine("Alerta: Sobrecarga no servidor");
            }
            else
            {
                Console.WriteLine("CPU sem risco de sobrecarga");
            }
        }
    }
}
