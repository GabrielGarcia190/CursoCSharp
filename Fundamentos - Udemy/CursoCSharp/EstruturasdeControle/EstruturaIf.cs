using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasdeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine(" Digite a nota do aluno");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Tem bom comportamento (S/N): ");

            entrada = Console.ReadLine();

            //if(entrada.ToUpper() == "S")
            //    bomComportamento = true;

            //bomComportamento = entrada.ToLower() == "true";
            bomComportamento = entrada.ToUpper() == "true";

            if (nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!!");
            }
            else
            {
                Console.WriteLine("Tu é merdinha chará...");
            }

        }
    }
}
