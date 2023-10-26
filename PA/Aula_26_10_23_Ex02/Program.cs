using System;

namespace Aula_26_10_23_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorFinanciado, valorParcela;
            int qtdparcela, contador = 1;

            Console.Write("Qual o valor parcelado?: ");
            valorFinanciado = float.Parse(Console.ReadLine());

            Console.Write("Em quantas vezes você deseja parcelar: ");
            qtdparcela = int.Parse(Console.ReadLine());

            valorParcela = valorFinanciado / qtdparcela;

            DateTime data = DateTime.Now.Date;

            do
            {
                //Console.WriteLine($"{contador}ª parcela: {valorFinanciado / qtdparcela:} ");
                Console.WriteLine($"{contador}ª parcela ({data}) {valorParcela:0.00} ");
                contador++;
                data = data.AddMonths(1);
            } while (contador <= qtdparcela);

        }
    }
}
