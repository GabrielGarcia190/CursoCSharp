using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormantandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1"));// UMA CASA APÓS A VIRGULA
            Console.WriteLine(valor.ToString("C"));// VALOR MONETARIO
            Console.WriteLine(valor.ToString("P"));// VALOR PERCENTUAL
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));//TRANSFORA A LINGUAGEM PADRÃO PARA INGLÊS AMERICANO

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));// COLOCA ALGUNS ZEROS NA FRENTE 
        }
    }
}

