using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            int num1 = 2;
            int num2 = 3;
            bool booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            //VERSÃO PÓS FIXADA
            num1++;
            Console.WriteLine(num1);
            --num1;
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2);
            // NUM2 SERÁ DECREMENTADO ANTES ANTES DA COMPRAÇÃO.
            // NUM1 SERÁ INCREMENTADO DEPOIS DA COMPRAÇÃO.
            // PORÉM NA LINHA DE BAIXO OS DOIS TEM VALORES DIFERENTES
            Console.WriteLine($"{num1},{num2}");
            
        }

    }
}
