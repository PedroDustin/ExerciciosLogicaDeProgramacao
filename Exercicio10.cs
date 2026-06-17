using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//10.Aviso de superaquecimento: Leia a temperatura de um roteador.
//Se for maior que 75 graus, exiba "Alerta de superaquecimento de hardware".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura do seu roteador");
            int temperatura = Convert.ToInt16(Console.ReadLine());

            if(temperatura > 75)
            {
                Console.WriteLine("Alerta de superaquecimento de hardware");
            }
        }
    }
}
