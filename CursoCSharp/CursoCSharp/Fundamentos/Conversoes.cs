using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int interio = 10;
            double quebrado = interio;
            //NESTE CASO HOUVE UMA CONVESÃO, PORÉM IMPLICITA
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);
            // SÓ É NECESSÁRIO REALIAR CONVERSÕES EM CASOS DE PERDAS DE DADOS

            Console.WriteLine("Digite sua Idade: ");
            string idadeString = Console.ReadLine( );
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            Console.Write("Digite o Primeiro Número: ");
            string palavra = Console.ReadLine( );
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado {0}", numero);

            Console.Write("Digite o Segundo número: ");
            int.TryParse(Console.ReadLine( ), out int numero1);
            Console.WriteLine("Resultado {0}", numero1);

        }

    }
}
