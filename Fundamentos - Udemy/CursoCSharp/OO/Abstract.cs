using System;
using System.Collections.Generic;

namespace CursoCSharp.OO
{
    class Abstract
    {
        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {
                return "Trim, Trim, Trim ....";
            }
        }

        public class Samsumg : Celular
        {
            public override string Assistente()
            {
                return "Olá! Meu nome é Bixby!";
            }
        }

        public class Iphone : Celular
        {
            public override string Assistente()
            {
                return "Olá meu nome é Siri!";
            }
        }


        public static void Executar()
        {

            var celulares = new List<Celular> {
                new Iphone(),
                new Samsumg()
        };


            foreach(var c in celulares)
            {
                Console.WriteLine(c.Assistente()) ;
            }
        }
    }
}
