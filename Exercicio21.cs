using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//21.Conceitos de notas: Leia a nota final de um aluno (0 a 10) e classifique-a: >= 9 (A), >= 7.5 (B), >= 6 (C), < 6 (D).

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio21
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua nota de 0 a 10");
            float notaAluno = float.Parse(Console.ReadLine());

            if (notaAluno >= 9)
            {
                Console.WriteLine("Nota do Aluno (A)");
            }
            else if (notaAluno >= 7.5)
            {
                Console.WriteLine("Nota do Aluno (B)");
            }
            else if (notaAluno >= 6)
            {
                Console.WriteLine("Nota do Aluno (C)");
            }
            else if (notaAluno <6)
            {
                Console.WriteLine("Nota do Aluno (D)");
            }
            
        }
    }
}
