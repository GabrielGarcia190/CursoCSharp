using System;

namespace CursoCSharp.ClassesEMetodos
{

    public struct Dependente
    {
        public string Nome;
        public int Idade;
    }
    //  public struct Dependente
    //{
    //    public string Nome;
    //    public int Idade;
    //} ISTO MUDARIA O VALOR E NÃO A REFERÊNCIA


    class ValorVsReferentecia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;

            Console.WriteLine($"{numero}, {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero}, {copiaNumero}");


            Dependente dep = new Dependente
            {
                Nome = "Gabriel",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome}, {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade}, {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 18;

            Console.WriteLine($"{dep.Nome}, {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade}, {copiaDep.Idade}");


        }
    }

}
