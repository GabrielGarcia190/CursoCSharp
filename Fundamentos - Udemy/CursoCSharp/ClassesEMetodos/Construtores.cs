using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Construtores
    {

        class Carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }

            public Carro() { }

        }

        public static void Executar()
        {
            var carro1 = new Carro
            (
               "Corsa",
               "Chevrolet",
               2007
            );

            var carro2 = new Carro
            {
                Modelo = "Monza",
                Fabricante = "Chevrolet",
                Ano = 2007
            };

            var carro3 = new Carro();

            carro3.Fabricante = "Volkswagen";
            carro3.Ano = 2010;
            carro3.Modelo = "Fox";

            Console.WriteLine(carro1);
        }
    }
}
