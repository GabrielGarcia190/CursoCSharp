using System;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }
    class StructvsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaponto1 = ponto1; // ATRIBUIÇÃO POR VALORES
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 :  X {0} ", ponto1.X);
            Console.WriteLine("Ponto 1 :  X {0} ", copiaponto1.X);

            CPonto ponto2 = new CPonto { X = 1, Y = 3 };
            CPonto copiaponto2 = ponto2; // ATRIBUIÇÃO POR REFERÊNCIA
            ponto2.X = 3;

            Console.WriteLine("Ponto 1 :  X {0} ", ponto2.X);
            Console.WriteLine("Ponto 1 :  X {0} ", copiaponto2.X);

        }
    }
}
