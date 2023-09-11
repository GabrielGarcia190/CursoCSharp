using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasdeControle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            // CONTINUE TERMINA A REPETIÇÃO DO FOR E INICIA  PROXIMA.
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.Write(i + " ");
            }


        }
    }
}
