using System;

namespace Aula_14_11_23_Ex01_SUBTRAÇÃO
{
    class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2;
             // string sub3 = "S";

            // while (sub3.ToUpper() == "S")

            for (int subtração = 1; subtração <=3; subtração++)
            {

                Console.WriteLine("Digite o primeiro número da subtração: ");
                sub1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número da subtração: ");
                sub2 = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine($"{sub1} - {sub2} = {sub1 - sub2}");

            }


        }
    }
}
