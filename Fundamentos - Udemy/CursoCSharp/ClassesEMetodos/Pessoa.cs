using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;


        public string Apresentar()
        {
            return string.Format($"Olá me chamo {Nome} e tenho {Idade} anos");
        }

        public void ApresentarnoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
