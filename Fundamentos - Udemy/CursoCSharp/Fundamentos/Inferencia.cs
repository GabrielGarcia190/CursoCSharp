using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {
        public static void Executar() {
            var nome = "Leonardo";
            Console.WriteLine(nome);

            var idade = 32;
            var verdade = true;
            Console.WriteLine(verdade);
            Console.WriteLine(idade);
            // No caso de inferência, a variável sempre tem que ser iniciada.
            // Tipando a variável não preciso inicializada
            int a;
            a = 32;
            Console.WriteLine(a);
        }
    }
}
