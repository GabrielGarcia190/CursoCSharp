using System;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //Action algoNoConsole = () =>
            //{
            //    Console.WriteLine("Lambda com C#");
            //};

            Action<string> algoNoConsole = (a) =>
            {
                Console.WriteLine("Lambda com C#" + a);
            };

            algoNoConsole("Teste");

            Func<int> jogarDado = () =>
            {
                Random rand = new Random();
                return (int)rand.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHEX = numero => numero.ToString("X");
            Console.WriteLine(conversorHEX(1234));


            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2/1:D2/2:D2}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 7, 2023));

        }
    }
}
