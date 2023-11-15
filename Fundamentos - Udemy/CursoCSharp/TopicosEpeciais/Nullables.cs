using System;

namespace CursoCSharp.TopicosEpeciais
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;

            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de {0}", num1);
            }
            else
            {
                Console.WriteLine("A variavel não possui valor");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booelana = null;
            bool resultado = booelana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
