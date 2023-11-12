using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MinhaSomaImprimir(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));

            ImprimirSoma op2 = MinhaSomaImprimir;
            op2(5.4, 8);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5,3));
            
            Action<double, double> op4 = MinhaSomaImprimir;
            op4(2.5,3);


        }

    }
}
