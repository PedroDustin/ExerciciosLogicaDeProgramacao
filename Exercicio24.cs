using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//24.Cálculo de IMC: Leia o peso e a altura. Calcule o IMC ($IMC = peso / (altura * altura)$). Classifique: < 18.5 (Abaixo do peso), entre 18.5 e 24.9 (Normal), entre 25.0 e 29.9 (Sobrepeso), >= 30 (Obesidade).
namespace ListaEstruturaDeDecisao
{
    internal class Exercicio24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu peso");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }else if (imc <= 24.9)
            {
                Console.WriteLine("Nomal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
        }
    }
}
