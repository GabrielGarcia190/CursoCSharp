using CursoCSharp.OO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosEpeciais
{

   public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1
    {
        public static  void Executar()
        {
            var alunos = new List<Aluno> { 
                new Aluno() {Nome = "PEDRO", Idade= 24, Nota = 10},
                new Aluno() {Nome = "aaaaa", Idade= 23, Nota = 9.0},
                new Aluno() {Nome = "bbbbb", Idade= 27, Nota = 8.2},
                new Aluno() {Nome = "ccccc", Idade= 2, Nota = 8.5},
                new Aluno() {Nome = "ddddd", Idade= 9, Nota = 8.9},
                new Aluno() {Nome = "eeeee", Idade= 5, Nota = 7.0},
                new Aluno() {Nome = "iiiii", Idade= 4, Nota = 6.0}
            };


            Console.WriteLine("===============APROVADOS===============");
            var aprovados = alunos.Where(a => a.Nota >= 10)
                .OrderBy(a => a.Nome);

            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("===============CHAMADA===============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("===========APROVADOR POR IDADE===========");
            var alunoAprovadas =
                from aluno in alunos
                where aluno.Nota >= 8.5
                orderby aluno.Idade
            select aluno.Nome;

            foreach(var aluno in alunoAprovadas)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
