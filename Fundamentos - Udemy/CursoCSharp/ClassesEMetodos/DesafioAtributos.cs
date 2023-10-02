using System;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributos
    {
        int a = 10;
       public static void Executar()
        {
            //Acessar variável 'a' dentro do metodo executar
            var resultado = new DesafioAtributos();
            Console.WriteLine(resultado.a);
        }

    }
}
