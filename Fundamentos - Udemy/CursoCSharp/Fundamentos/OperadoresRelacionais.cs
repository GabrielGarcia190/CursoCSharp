using System;


namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a sua nota: ");
            double.TryParse(Console.ReadLine( ), out double nota);
            double notaDeCorte = 7.0;
            Console.WriteLine("Nota Invalida {0} ?", nota > 10.00 && nota < 10.00);
            Console.WriteLine("Nota Invalida {0} ?", nota < 0.00 && nota < 10.00);
            Console.WriteLine("Nota Invalida {0} ?", nota == 10.00);
            Console.WriteLine("Nota Invalida {0} ?", nota != 10.00);
            Console.WriteLine("Pode melhoerar ? {0} ?", nota >= notaDeCorte);
        }
    }
}

