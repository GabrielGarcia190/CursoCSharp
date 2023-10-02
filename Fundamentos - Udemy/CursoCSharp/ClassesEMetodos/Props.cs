using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Props
    {
        public class CarroOpcional
        {
            double desconto = 0;

            string nome;
            public string Nome
            {
                get
                {
                    return "Opcional: " + nome;
                }
                set
                {
                    nome = value;
                }
            }

            public double Preco { get; set; }

            public double PrecoComDesconto
            {
                get => Preco - (desconto * Preco);
            }

            public CarroOpcional() { }

            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

        }

        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);

            //op1.PrecoComDesconto = 300;

            var op2 = new CarroOpcional();
            op2.Nome = "Teste";
            op2.Preco = 1000;

            Console.WriteLine(op2.Nome);
        }
    }
}
