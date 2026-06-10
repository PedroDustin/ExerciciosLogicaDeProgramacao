using System;
using System.Collections.Generic;
using System.Text;

//5.Controle de commits: Leia o número de commits de um aluno no GitHub durante a semana.
//Se o valor] for maior que 0, exiba "Repositório atualizado".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de commits que você fez nessa semana");
            int commitsAluno = Convert.ToInt16(Console.ReadLine());

            if (commitsAluno > 0)
            {
                Console.WriteLine("Repositório atualizado");
            }
            else
            {
                Console.WriteLine("Faça um commit");
            }
        }
    }
}
