using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasdeControle
{
    internal class UsandoBrake
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);
            //OBS: BREAK NÃO SAI DO IF, SOMENTE ENCERRA O FOR, POIS SÓ ESTÁ ASSOCIADO AO SWITCH OU UM LAÇO DE REPETIÇÃO.
            Console.WriteLine("O número que queremos é {0}", numero);
            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine($"{i} é o número que queremos");
                if( i == numero)
                {
                    Console.WriteLine("Sim!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não");
                }
            }
        }
    }
}
