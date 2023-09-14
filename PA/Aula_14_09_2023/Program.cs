using System;

namespace Aula_14_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, n3, n4, media;

            Console.Write("Informe a primeira nota: ");
            n1 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            n2 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            n3 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a quarta nota: ");
            n4 = decimal.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média obtida é: " + media);

            //Console.WriteLine("A média obtida é: " + (n1 + n2 + n3 + n4) / 4); outra maneira de fazer o cálculo//

            //Console.WriteLine($"A média final é: {media}"); interpolação//
        }   
    }
}
