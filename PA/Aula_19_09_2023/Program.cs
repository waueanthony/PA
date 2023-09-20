using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4;

            Console.Write("Informe a primeira nota");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe a quarta nota");
            nota4 = float.Parse(Console.ReadLine());
        }
    }
}
