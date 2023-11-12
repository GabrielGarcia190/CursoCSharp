using System;

namespace CursoCSharp.API
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);


            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddSeconds(15);

            var tempo = largada - chegada;

            Console.WriteLine("Duração: " + tempo);

            Console.WriteLine(tempo.GetType().Name);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine("ToString" + intervalo.ToString("g"));
            Console.WriteLine("ToString" + intervalo.ToString("G"));
            Console.WriteLine("ToString" + intervalo.ToString("c"));
        }
    }
}
