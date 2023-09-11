using CRUD2_0.DTO;
using System;

namespace CRUD2_0.Model
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, decimal precoCusto, decimal precoVenda)
        {
            Nome = nome;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
        }

        public Produto(int id, string nome, decimal precoCusto, decimal precoVenda)
        {
            Id = id;
            Nome = nome;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }

        public DadosRetornoDTO Validar()
        {

            if (String.IsNullOrEmpty(Nome))
            {
                return new DadosRetornoDTO() { mensagemErro = "Preenche corretamente o nome do produto", sucesso = false };
            }

            if (PrecoCusto == 0)
            {
                return new DadosRetornoDTO() { mensagemErro = "Preenche corretamente o valor de custo", sucesso = false };
            }
            if (PrecoVenda == 0) return new DadosRetornoDTO() { mensagemErro = "Preenche corretamente o valor de venda", sucesso = false };

            return new DadosRetornoDTO() { mensagemErro = "Dados cadastrados com sucesso. ", sucesso = true };


        }
    }
}
