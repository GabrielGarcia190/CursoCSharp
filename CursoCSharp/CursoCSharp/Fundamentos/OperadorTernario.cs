using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            double nota = 9.0;
            bool comportamento = true;

            var resultado = nota >= 7.0 && comportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }

    }
}

