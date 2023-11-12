namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro() { }

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlertaVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public int Acelerar()
        {
            return AlertaVelocidade(4);
        }

        public int Frear()
        {
            return AlertaVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200) { }
    }
    class Heranca
    {
        public static void Executar()
        {

        }
    }
}
