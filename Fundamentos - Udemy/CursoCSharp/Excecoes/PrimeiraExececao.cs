using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta {
        double Saldo;

        public Conta (double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo Insufiiente");
            }

            Saldo -= valor;
        }
    }

    internal class PrimeiraExececao
    {

        public static void Executar()
        {
            var conta = new Conta(1_233.45);


            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Saque efetuado com sucesso");

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado !");
            }
        }
    }
}
