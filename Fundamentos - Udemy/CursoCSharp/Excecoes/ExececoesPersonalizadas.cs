using System;

namespace CursoCSharp.Excecoes
{
    public class NegativaException : Exception
    {
        public NegativaException() { }

        public NegativaException(string message) : base(message) { }

        public NegativaException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparExeception : Exception
    {
        public ImparExeception(string message) : base(message) { }
    }
    class ExececoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random rnd  = new Random();
            int valor = rnd.Next(-30, 30);

            if(valor < 0)
            {
                throw new NegativaException("Numero Negativo ....");
            }

            if (valor % 2 == 1) throw new ImparExeception("Valor Impar ....");

            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }catch (NegativaException ex)
            {
                Console.WriteLine(ex.Message);
            }catch (ImparExeception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
