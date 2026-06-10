using System;
using System.Collections.Generic;
using System.Text;

//4.Verificação de repouso: Leia a quantidade de horas que um aluno estudou no dia.
//Se for maior que 10, exiba "Aviso: Necessário intervalo para descanso".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite quantas horas você estudou no dia");
            float horasEstudadas = float.Parse(Console.ReadLine());

            if (horasEstudadas > 10)
            {
                Console.WriteLine("Nescessário intervalo para descanso");
            }
        }
    }
}
