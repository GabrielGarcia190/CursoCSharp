using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2016, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004" + filmes[2004]);
                Console.WriteLine("2004" + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Amnséia"));

            Console.WriteLine($"Romoveu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2016, out string filmes2006);
            Console.WriteLine($"Filme: {filmes2006})");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine("============CHAVE============");
                Console.WriteLine("Chave:", chave);
                Console.WriteLine("=============================");
            }

            foreach (var chave in filmes.Values)
            {
                Console.WriteLine("============FILMES============");
                Console.WriteLine("Filmes:", chave);
                Console.WriteLine("=============================");
            }

         
            foreach(KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine("============FILMES E ANOS============");
                Console.WriteLine($"Filmes: {filme.Value} \nAno: {filme.Key} ");
                Console.WriteLine("=============================");
            }

            //FORMA IMPLICITA
            foreach (var filme in filmes)
            {
                Console.WriteLine("============FILMES E ANOS============");
                Console.WriteLine($"Filmes: {filme.Value} \nAno: {filme.Key} ");
                Console.WriteLine("=============================");
            }
        }
    }
}
