using System;

namespace CursoCSharp.TopicosEpeciais
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 9.5;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome}, {aluno.idade}, {aluno.nota}");

        }
    }
}
