using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface operacaoBinaria
    {
        int Operacao(int a, int b);
    }
    interface Teste
    {
        bool Bla(string a);
    }
    //interface operacaoBinaria : Teste
    //{
    //    int Operacao(int a, int b);
    //}


    class Soma : operacaoBinaria, Teste
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }

        public bool Bla(string outraCoisa)
        {
            return false;
        }
    }
    class Subtracao : operacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : operacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }
    class Divisao : operacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a / b;
        }
    }

    class Calculadora
    {
        List<operacaoBinaria> operacoes = new List<operacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
            new Divisao(),
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}";
            }

            return resultado;
        }
    }

    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);

            Console.WriteLine(resultado);
        }
    }
}
