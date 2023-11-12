using System;
using System.IO;

namespace CursoCSharp.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = "C:/dev/Fundamentos_Udemy/Fundamentos - Udemy/CursoCSharp";

            if(Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if(Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("===========PASTAS================");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n \n===ARQUIVOS================");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos) Console.WriteLine(arquivo); 
            
            Console.WriteLine("\n \n===RAIZ================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }
        }
    }
}
