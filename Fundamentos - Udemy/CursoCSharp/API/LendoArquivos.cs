using System;
using System.IO;

namespace CursoCSharp.API
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("aaaaaaaaaaaaaaaaaaaaaa");
                    sw.WriteLine("bbbbbbbbbbbbbbbbbbbbbb");
                    sw.WriteLine("cccccccccccccccccccccc");
                }
            }

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
