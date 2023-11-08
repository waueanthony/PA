using System;

namespace Aula_07_11_23_Ex03_num_Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 >= 0.00000000000000000000000001)
            {
                Console.WriteLine("Este número é ímpar");
            }
            else
            {
                Console.WriteLine("Este número é par");
            }
        }
    }
}
