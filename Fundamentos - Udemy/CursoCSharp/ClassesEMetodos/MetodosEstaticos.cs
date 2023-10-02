using System;

namespace CursoCSharp.ClassesEMetodos
{

    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var soma = CalculadoraEstatica.Somar(1,2);

            var multi = CalculadoraEstatica.Multiplicar(1,2);
            

            Console.WriteLine($"{soma} + {multi}");

        }
    }
}
