using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual o seu nome ? ");
            string nome = Console.ReadLine( );

            Console.Write("Qual a sua idade ? ");
            int idade = int.Parse(Console.ReadLine( ));

            Console.Write("Qual o seu salário ? ");
            double salario = double.Parse(Console.ReadLine( ),
                CultureInfo.InvariantCulture);

            Console.Write($"O seu nome é {nome}, idade: {idade}, salario: R$ {salario} ");
        }
    }
}





