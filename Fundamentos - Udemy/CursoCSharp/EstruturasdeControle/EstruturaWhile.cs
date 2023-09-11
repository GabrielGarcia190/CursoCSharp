using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasdeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0; ;

            Random random = new Random();

            int numeroSorteado = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Digite seu palpite;");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;
                if (numeroSorteado == palpite)
                {
                    numeroEncontrado = true;
                    var CorAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("ACERTOU MISERAVI - TENTATIVAS {0}", tentativas);
                    Console.BackgroundColor = CorAnterior;
                    return;
                }
                else if (palpite > numeroSorteado)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine(" TENTATIVAS  RESTANTES {0}", tentativasRestantes);

                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine(" TENTATIVAS  RESTANTES {0}", tentativasRestantes);
                }

            }

            if (tentativas >= 5)
            {
                var CorAnterior = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("SUA TENTATIVAS ACABARAM");
                Console.BackgroundColor = CorAnterior;
            }
        }
    }
}
