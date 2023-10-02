using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {

        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Gabriel";
            sicrano.Idade = 20;

            //Console.WriteLine($"{sicrano.Nome}, {sicrano.Idade}");
            sicrano.ApresentarnoConsole();

            var pessoa = new Pessoa { 
            Nome = "Teste de Souza",
            Idade = 13
            };


            pessoa.ApresentarnoConsole();
        }
    }
}
