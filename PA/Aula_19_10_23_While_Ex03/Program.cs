using System;

namespace Aula_19_10_23_While_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator, numeroFinal;

            Console.Write("Informe o fator: ");
            fator = int.Parse(Console.ReadLine());

            Console.Write("Informe o número final: ");
            numeroFinal = int.Parse(Console.ReadLine());

            int contador = 1;
            while (contador <= numeroFinal)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                //contador = contador + 1;
                contador++; //++ é  igual a propria variavel +1 / -- é igual a variavel -1

            }
            Console.WriteLine("\n*** Fim da Tabuada ***");
        }
    }
}
