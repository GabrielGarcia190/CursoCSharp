using System;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {

        public class Moto
        {
            private string Marca;
            private string Modelo;
            private int Cilindrada;

            public Moto(string marca, string modelo, int cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;

                SetModelo(modelo);
                SetMarca(marca);
                SetCilindrada(cilindrada);
            }

            public Moto() { }

            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }


            public string GetModelo()
            {
                return Modelo;
            }

            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }


            public int GetCilindrada()
            {
                return Cilindrada;
            }

            public void SetCilindrada(int cilindrada)
            {
                //if (cilindrada > 0)
                //{
                //Cilindrada = cilindrada;
                //}
                //else
                //{
                //    cilindrada = 0;
                //}
                Cilindrada = Math.Abs(cilindrada);  
            }
        }

        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", -636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetModelo("Titan");
            moto2.SetMarca("Honda");
            moto2.SetCilindrada(125);

            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());
            Console.WriteLine(moto2.GetMarca());
        }
    }
}
