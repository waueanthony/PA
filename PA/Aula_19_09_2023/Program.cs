using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;

            Console.Write("Informe a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe a quarta nota: ");
            nota4 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média obtida é: " + media);

            //0.00 a 4.99 - reprovado
            //5.00 a 6.99 - recuperação
            //7.00 a 10.00 - aprovado

            if (media < 5)
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Poxa que Pena");
            }
            else if (media < 7)
            {
                Console.WriteLine("Recuperação");
                Console.WriteLine("Coragem!");

            }

            else
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Parabéns!");
            }
            

            // if faz teste condicional apenas com true or false
            // <> sinais de comparação (==) sinal de igualdade (=) atribuição
            // uso das {} só necessario caso haja mais que uma linha de instrução apos o if e else

            //else == senão     //if == se

        }
    }
}
