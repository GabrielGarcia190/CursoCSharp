using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosEpeciais
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "PEDRO", Idade= 24, Nota = 10},
                new Aluno() {Nome = "aaaaa", Idade= 23, Nota = 9.0},
                new Aluno() {Nome = "bbbbb", Idade= 27, Nota = 8.2},
                new Aluno() {Nome = "ccccc", Idade= 2, Nota = 8.5},
                new Aluno() {Nome = "ddddd", Idade= 9, Nota = 8.9},
                new Aluno() {Nome = "eeeee", Idade= 5, Nota = 7.0},
                new Aluno() {Nome = "aaaaa", Idade= 4, Nota = 6.0}
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine(pedro.Nome + ": Nota: " + pedro.Nome);

            var _fulano = alunos.SingleOrDefault(
                _aluno => _aluno.Nome.Equals("aaaaa"));

            var _sicrano= alunos.SingleOrDefault(
                _aluno => _aluno.Nome.Equals("aaaaa"));
            Console.WriteLine(_sicrano);


            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);   

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);    

            var somarNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somarNotas);  

            var mediaNotas = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotas);


        }
    }
}
