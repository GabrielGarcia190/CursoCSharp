using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {

        public static void Recepcionar(params string[] pessoa)
        {
            foreach (var p in pessoa)
            {
                Console.WriteLine($"Olá {p}");
            }
        }
        public static void Executar()
        {
            Recepcionar("Gabriel", "Dany", "Pedro", "Ana");
        }
    }
}
