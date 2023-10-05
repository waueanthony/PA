using System;

namespace Aula_05_10_23_num10
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;

            Console.Write("Digite o valor desejado: ");
            num1 = float.Parse(Console.ReadLine());

            if (num1 > 10)
            {
                Console.WriteLine("Este número é maior que 10");
            }
            else
                Console.WriteLine("Este número é menor que 10");
        }
    }
}
