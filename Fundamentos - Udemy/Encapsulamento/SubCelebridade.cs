namespace Encapsulamento
{
    class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenha um instagram!";

        //herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5517999999999;

        //herança ou no mesmo projeto
        protected internal string JeitoDeFalar = "Uso de muitas línguas";

        //mesma classe ou herança no mesmo projeto
        private protected string SegredoFamilia = "Bla Bla";

        //private é padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade.....");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
