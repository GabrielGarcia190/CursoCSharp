using System;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExetensaoInteiro {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }
        public static int Sbtracao(this int num, int outroNumero)
        {
            return num + outroNumero;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Sbtracao(10));
            
            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Sbtracao(10));


        }
    }
}
