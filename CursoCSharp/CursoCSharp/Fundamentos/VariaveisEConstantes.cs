using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * (raio * raio);

            Console.WriteLine(area);
            Console.WriteLine("Aréa: "+ area);


            //Tipo Internos 
            bool estaChovendo = true;
            Console.WriteLine("Esta Chovendo" + estaChovendo);

            byte idade =  byte.MaxValue;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario: R$" + salario );

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor Valor do Inteiro: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor do Long: " + menorValorLong);
            
            ulong populacaoMundial = ulong.MaxValue;
            Console.WriteLine("Menor Valor do Long: " + populacaoMundial);
        }
    }
}
