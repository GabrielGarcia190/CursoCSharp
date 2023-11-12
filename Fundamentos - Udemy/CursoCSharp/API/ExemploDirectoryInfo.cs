using System;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = "C:/dev/Fundamentos_Udemy/Fundamentos - Udemy/CursoCSharp";

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("=======ARQUIVOS========");
            var arquivos = dirInfo.GetFiles();
            Console.WriteLine(arquivos);

            Console.WriteLine("=======DIRETÓRIOS========");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) Console.WriteLine(pasta);

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent);

        }
    }
}
