using System;

namespace Aula_07_11_23_Ex02_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;

            Console.Write("Informe o fator: ");
            fator = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++) 
            {
                Console.WriteLine($"{fator} X {contador} = {fator * contador}");
            }
        }
    }
}

