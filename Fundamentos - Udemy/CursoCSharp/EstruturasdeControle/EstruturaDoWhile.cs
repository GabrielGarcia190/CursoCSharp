using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasdeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine( );

                Console.WriteLine("Seja Bem Vindo");
                Console.WriteLine("Deseja concitnuar? S/N");
                entrada = Console.ReadLine( );

            } while(entrada.ToLower( ).Equals("s"));
        }
    }
}
