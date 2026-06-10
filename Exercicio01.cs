using System;
using System.Collections.Generic;
using System.Text;

//1. Validação de nota: Leia a nota de um aluno em Cálculo 1. Se a nota for maior ou igual a 6.0, exiba "Aprovado".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota:");
            float nota = float.Parse(Console.ReadLine());

            if (nota >= 6){
                Console.WriteLine("Aprovado!!");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
