using System;

namespace Aula_05_10_23_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            float s1 ;

            Console.Write("Informe seu salário: ");
            s1 = float.Parse(Console.ReadLine());

            if (s1 <= 3000)
            {
                Console.Write("Você recebeu um reajuste de 50%, logo seu novo saláro será: ");
                Console.WriteLine(s1 * 0.5 + 3000);

            }
            else if (s1 <= 7000)
            {
                Console.Write("Você recebeu um reajuste de 20%, logo seu novo saláro será: ");
                Console.WriteLine(s1 * 0.2 + s1);
            }
            else if (s1 <= 10000)
            {

















                Console.Write("Você recebeu um reajuste de 15%, logo seu novo saláro será: ");
                Console.WriteLine(s1 * 0.15 + s1);
            }
            else
            {
                Console.Write("Você recebeu um reajuste de 10%, logo seu novo saláro será: ");
                Console.WriteLine(s1 * 0.10 + s1);
            }


        }
    }
}
