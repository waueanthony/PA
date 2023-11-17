using System;

namespace Aula_14_11_23_Ex02_NUMEROS_IMPAR_ATE_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número para que seja destacado os números ímpares dele: ");
            num = int.Parse(Console.ReadLine());

            for (int i =1 ; i<= num; i++)
            //for (int i = 1; 1 <= num; i--)
            {
                if (i % 2 >= 0.1)
                {
                    Console.WriteLine($"{i }  é impar");
                }
                else
                {
                    Console.WriteLine();
                }
                 


            }
        }
    }
}
