using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//29.Menu de conversão térmica: Exiba um menu e leia a opção. 1: Celsius para Fahrenheit, 2: Celsius para Kelvin, 3: Fahrenheit para Celsius.
//Realize o cálculo correspondente à escolha usando as fórmulas matemáticas e exiba o resultado. Caso a opção seja inválida, exiba "Opção incorreta".

namespace ListaEstruturaDeDecisao
{
    internal class Exercicio29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura que deseja fazer a conversão");
            float temperatura = float.Parse(Console.ReadLine());

            Console.WriteLine("1-Celsius para Fahrenheit");
            Console.WriteLine("2-Celsius para Kelvin");
            Console.WriteLine("3-Fahrenheit para Celsius");
            int conversaoTermica = Convert.ToInt16(Console.ReadLine());

            double resultadoFinal = 0;

            if (conversaoTermica == 1)
            {
                resultadoFinal = (temperatura * 1.8) + 32;
                Console.WriteLine("O resultado da conversão de Celsius para Fahrenheit é: " +" "+resultadoFinal);
            }
            else if (conversaoTermica == 2)
            {
                resultadoFinal = temperatura + 273;
                Console.WriteLine("O resultado da conversão de Celsius para Kelvin é: " + " " + resultadoFinal);
            }
            if (conversaoTermica == 3)
            {
                resultadoFinal = (temperatura - 32) * 5/9;
                Console.WriteLine("O resultado da conversão de Fahrenheit para Celsius é: " + " " + resultadoFinal);
            }

        }
    }
}
