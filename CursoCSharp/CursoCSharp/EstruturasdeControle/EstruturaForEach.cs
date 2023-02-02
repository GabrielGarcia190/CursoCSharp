using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasdeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            //var palavra = "Opa!";

            //foreach(var letra in palavra)
            //{
            //    Console.WriteLine(letra.ToString( ));
            //}

            var alunos = new String[] { "Ana", "Gabriel", "Paulo" };

            foreach(String aluno in alunos)
            {
                Console.WriteLine($"Nome do aluno: {aluno}");
            }

        }
    }
}
