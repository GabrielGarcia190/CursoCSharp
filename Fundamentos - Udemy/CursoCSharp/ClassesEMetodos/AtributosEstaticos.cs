using System;

namespace CursoCSharp.ClassesEMetodos
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;
        //public double Desconto = 0.1;

        public Produto(string nome, double preco, double descricao)
        {
            Nome = nome;
            Preco = preco;
            Desconto = descricao;
        }

        public Produto() { }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() { 
            Nome = "Borracha",
            Preco = 55.3
            };

            Produto.Desconto = 0.5;
            Console.WriteLine(produto1.CalcularDesconto());
            Console.WriteLine(produto2.CalcularDesconto());;


            Produto.Desconto = 0.1;
            Console.WriteLine(produto1.CalcularDesconto());
            Console.WriteLine(produto2.CalcularDesconto());

        }

    }
}
