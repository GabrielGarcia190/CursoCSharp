using System;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploFiloInfo
    {
        public static void ExlcuirSeExistir( params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquvo = new FileInfo(caminho);

                if (arquvo.Exists)
                {
                    arquvo.Delete();
                }
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"~\arq_Origem.txt".ParseHome();
            var caminhoDestino = @"~\arq_destino.txt".ParseHome();
            var caminhoCopia = @"~\arq_copia.txt".ParseHome();

            ExlcuirSeExistir(caminhoCopia, caminhoDestino, caminhoOrigem);

            using (StreamWriter sw = File.CreateText(caminhoOrigem)){
                sw.WriteLine("Arquivo Original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
