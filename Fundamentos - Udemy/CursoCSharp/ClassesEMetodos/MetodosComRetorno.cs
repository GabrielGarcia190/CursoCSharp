using System;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {

        public int Somar(int a, int b)
        {
            return a + b;
        }
    }


    class CalculadoraCadeira
    {
        int memoria;

        public CalculadoraCadeira Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeira Subtrair(int a)
        {
            memoria -= a;
            return this;
        }
        public CalculadoraCadeira Mutiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeira Limpar()
        {
            memoria = 0;
            return this;
        }


        public CalculadoraCadeira Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
    }

    class MetodosComRetorno
    {


        public static void Executar()
        {
            var resutado = new CalculadoraComum().Somar(1, 2);

            Console.Write(resutado);

            var calculadoraCadeira = new CalculadoraCadeira();

            calculadoraCadeira.Somar(3).Mutiplicar(4).Imprimir()
                .Limpar().Imprimir();
        }
    }
}
