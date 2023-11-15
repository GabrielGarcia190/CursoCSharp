using System;

namespace CursoCSharp.TopicosEpeciais
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
        }

        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPrivado;
        }

        class CaixaInt : Caixa<int>
        {
            public CaixaInt() : base(0) { }
        }
    }
    class Genericos
    {
        
        public static void Executar()
        {

            var caixa1 = new Caixa<int>(100);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Mètodo"));
            Console.WriteLine(caixa2.Coisa.GetType());
        }
    }
}
