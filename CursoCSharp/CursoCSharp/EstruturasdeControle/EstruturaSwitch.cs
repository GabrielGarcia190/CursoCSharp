using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasdeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie seu atendimento com uma nota de 1 - 5");
            int.TryParse(Console.ReadLine(), out int nota);


            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    {
                        Console.WriteLine("Irregular");
                        break;
                    }
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Execelente");
                    break;
                default:
                    Console.WriteLine("Nota Invalida");
                    break;
            }

            Console.WriteLine("Obrigado por responder");
        }
    }
}
