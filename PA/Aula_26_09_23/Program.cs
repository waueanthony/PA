using System;

namespace Aula_26_09_23
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media, percFreq;

            Console.Write("Informe a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe a quarta nota: ");
            nota4 = float.Parse(Console.ReadLine());

            Console.Write("Informe o % de frequência: ");
            percFreq = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média obtida é: " + media);

            //0.00 a 4.99 - reprovado  e % Frequencia <= 40 - Reprovado
            //5.00 a 6.99 - recuperação  e % Frequencia <= 60 - Recuperação
            //7.00 a 10.00 - aprovado  e % Frequencia > 60 - Aprovado

            if (media < 5 && percFreq <= 40)
            {
                Console.WriteLine("Aluno Reprovado");
            }
            else if (media < 7 && percFreq <= 60)
            {
                Console.WriteLine("Aluno em Recuperação");
            }
            else if (media >= 7 && percFreq > 60)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Será analisado pela secretaria acadêmica");
            }

        }
    }
}
