using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//12.Latência de rede: Leia o tempo de resposta de um ping em milissegundos.
//Se for menor ou igual a 100ms, exiba "Conexão Estável", senão exiba "Conexão Lenta".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o tempo de resposta do seu ping em milissegundos");
            int ping = Convert.ToInt16(Console.ReadLine());

            if (ping <= 100)
            {
                Console.WriteLine("Conexão Estável");
            }
            else
            {
                Console.WriteLine("Conexão Lenta");
            }
        }
    }
}
