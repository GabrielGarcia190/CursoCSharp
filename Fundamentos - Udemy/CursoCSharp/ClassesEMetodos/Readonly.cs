using System;

namespace CursoCSharp.ClassesEMetodos
{

    class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        // Atributos const devem ser inicializados, porém o readonly, também não pode ser alterado depois de inicializado no construtor.

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            //Nascimento = DateTime.Now; se usar esta linha como o atributo é readonly ele não pode ser mais alterado.
        }

        public string GetDataNacismento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
    {
        static public void Executar()
        {
            var cliente = new Cliente("Gabriel", new DateTime(2003, 03, 27));

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.GetDataNacismento());
        }
    }
}
