using System;

namespace Aula_16_11_23_ex_add
{
    class Program
    {
        static void Main(string[] args)

        {
            int idade;
            int contador = 0;
            int somaIdade = 0;

            do 
            {
                Console.WriteLine("Digite as idades que deseja obter a média(digite 0 para encerrar): ");
                idade = int.Parse(Console.ReadLine());

                if (idade == 0)
                    break;
                somaIdade += idade;
                contador++;

            } while (idade != 0  );

            Console.Write($"a média das idades é {somaIdade / contador}"); 
        }
    }
}
        
    

