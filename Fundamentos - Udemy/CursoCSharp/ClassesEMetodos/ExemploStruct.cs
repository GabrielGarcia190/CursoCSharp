using System;

namespace CursoCSharp.ClassesEMetodos
{

    interface IPonto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : IPonto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;

            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Incinial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 2, y: 2);

            coordenadaFinal.MoverNaDiagonal(2);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}
