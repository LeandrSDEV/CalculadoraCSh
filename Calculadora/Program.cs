using System;
using System.Runtime.Serialization;

namespace Calculadora
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual operação deseja realizar o calculo? ");
            Console.WriteLine("1 - Adição ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Multiplicação ");
            Console.WriteLine("4 - Divisão ");
            int Operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            double num2 = double.Parse(Console.ReadLine());

            double res = 0;

            switch (Operacao) {
                case 1:
                    res = num1 + num2;
                    break;
                case 2:
                    res = num1 - num2;
                    break;
                case 3:
                    res = num1 * num2;
                    break;
                case 4:
                    res = num1 / num2;
                    break;  
                default: Console.WriteLine("Número invalido!");
                    break;
            }

            Console.WriteLine("O resultado da operação com os números {0} e {1} é: {2}", num1, num2, res);

            Console.WriteLine();

        }


    }
}