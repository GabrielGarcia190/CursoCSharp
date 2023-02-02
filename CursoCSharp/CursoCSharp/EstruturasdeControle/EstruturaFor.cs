using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasdeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma");
            entrada = Console.ReadLine( );
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine($"Informe a nota do aluno: {i}");
                entrada = Console.ReadLine( );
                double.TryParse(entrada, out double notaAluno);

                somatorio += notaAluno;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("A Media da Turma: {0}", media);
        }
    }
}
