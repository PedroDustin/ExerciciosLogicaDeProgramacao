using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//13.Frequência acadêmica: Leia o número de faltas de um aluno em um semestre de Introdução à Engenharia.
//Se for maior que 15, exiba "Reprovado por faltas", senão exiba "Frequência dentro do limite".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de faltas que você tem no semestre");
            int faltas = Convert.ToInt16(Console.ReadLine());

            if(faltas > 15)
            {
                Console.WriteLine("Reprovado por faltas");
            }
            else
            {
               Console.WriteLine("Frequência dentro do limite");
            }
        }
    }
}
