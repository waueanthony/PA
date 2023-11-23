using System;

namespace Aula_23_11_23_Ex02__aula_q_faltei_dia_21_11_
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto = -1;
            int totalVotoCand1 = 0,
                totalVotoCand2 = 0,
                totalVotoCand3 = 0,
                totalVotoCand4 = 0,
                totalVotoNulo = 0,
                totalVotoBranco = 0,
                totalVotos;



            Console.WriteLine("           BRANCO 5: ");
            Console.WriteLine("           NULO 6: ");
            Console.WriteLine("           ENCERRAR 0: ");
            Console.WriteLine();
            Console.WriteLine();


            while ( voto != 0 )
            
            {
                Console.Clear();
                Console.WriteLine("===========CANDIDATOS=============");
                Console.WriteLine();
                Console.WriteLine("Para votar no Candidato01 - 1: ");
                Console.WriteLine();
                Console.WriteLine("Para votar no Candidato02 - 2: ");
                Console.WriteLine();
                Console.WriteLine("Para votar no Candidato03 - 3: ");
                Console.WriteLine();
                Console.WriteLine("Para votar no Candidato04 - 4: ");
                Console.WriteLine();

                Console.Write("Informe seu voto: "); 
                voto = int.Parse(Console.ReadLine());


                switch (voto)
                {
                    case 1:
                        totalVotoCand1 += 1;
                        break;
                    case 2:
                        totalVotoCand2 += 1;
                        break;
                    case 3:
                        totalVotoCand3 += 1;
                        break;
                    case 4:
                        totalVotoCand4 += 1;
                        break;
                    case 5:
                        totalVotoNulo += 1;
                        break;
                    case 6:
                        totalVotoBranco += 1;
                        break;
                    default:
                        if (voto != 0)
                        {
                           // Console.WriteLine("voto não computado");
                            //Console.ReadLine();
                        }
                       
                        break;
                      
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("===========RESULTADO=============");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine($" A quantidade de votos para o Candidato01 foi de: {totalVotoCand1}");
                Console.WriteLine();
                Console.WriteLine($" A quantidade de votos para o Candidato02 foi de: {totalVotoCand2}");
                Console.WriteLine();
                Console.WriteLine($" A quantidade de votos para o Candidato03 foi de: {totalVotoCand3}");
                Console.WriteLine();
                Console.WriteLine($" A quantidade de votos para o Candidato04 foi de: {totalVotoCand4}");
                Console.WriteLine();
                Console.WriteLine($" A quantidade de votos nulos foi de: {totalVotoNulo}");
                Console.WriteLine();
                Console.WriteLine($" A quantidade de votos em branco foi de: {totalVotoBranco}");

               totalVotos = totalVotoCand1 + totalVotoCand2 + totalVotoCand3 + totalVotoCand4 + totalVotoNulo + totalVotoBranco;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("===========PERCENTUAIS=============");

                Console.WriteLine();

                Console.WriteLine($" A percentagem de votos nulos sobre o total de votos é {totalVotoNulo / 100 * totalVotos} %" );
                Console.WriteLine();
                Console.WriteLine($" A percentagem de votos nulos sobre o total de votos é {(totalVotoBranco / totalVotos) * 100} %");


                








            }



        }
    }
}
