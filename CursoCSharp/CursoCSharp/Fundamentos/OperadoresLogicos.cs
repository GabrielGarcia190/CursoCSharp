using System;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;


            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou TV 50 ? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho2 || executouTrabalho1;
            Console.WriteLine("Comprou Sorvete {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho2 ^ executouTrabalho1;
            Console.WriteLine("Comprou Tv 32 ? {0}", comprouTv32);

            Console.WriteLine("Mais Saudável ? {0}", !comprouSorvete);
        }

    }
}
