using System;

namespace Aula_17_10_23
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            string operador;

            Console.Write("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Selecione um operador: ");
            operador = (Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.Write("A soma dos valores é: ");
                    Console.Write(num1 + num2);
                    break;
                case "-":
                    Console.Write("A subtração dos valores é: ");
                    Console.Write(num1 - num2);
                    break;
                case "*":
                    Console.Write("A multiplicação dos valores é: ");
                    Console.Write(num1 * num2);
                    break;
                case "/":
                    Console.Write("A divisão dos valores é: ");
                    Console.Write(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Operador inválido");
                    break;

            }
        }
    }
}