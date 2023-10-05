using System;

namespace Aula_05_10_23
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

            if (operador == "+")
            {
                Console.Write("A soma dos valores é: ");
                Console.Write(num1 + num2);
            }
            else if (operador == "*")
            {
                Console.Write("A multiplicação dos valores é: ");
                Console.Write(num1*num2);
            }
            
            else if (operador == "-")
            {
                Console.Write("A subtração dos valores é: ");
                Console.Write(num1 - num2);

            }
            else if(operador =="/")
            {
                Console.Write("A divisão dos valores é: ");
                Console.Write(num1 / num2);
            }
        }
    }
}
