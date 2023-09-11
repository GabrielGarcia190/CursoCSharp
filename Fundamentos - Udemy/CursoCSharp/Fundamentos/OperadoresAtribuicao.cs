using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10;//num1 = num1 + 10;
            num1 -= 3;//num1 = num1 - 3;
            num1 *= 5;//num1 = num1 * 5;
            num1 /= 2; //num1 = num1 / 2;

            Console.WriteLine(num1);

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Gabriel";

            dynamic d = c;

            d.nome = "Paulo";

            Console.WriteLine(c);
        }
    }
}
