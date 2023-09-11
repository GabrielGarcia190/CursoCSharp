using CRUD2_0.Model;
using Dapper;
using System;

namespace CRUD2_0.Service
{
    public class CadastrarProduto
    {
        public bool Cadastrar(Produto produto)
        {
            try
            {

                using (var conexao = ConexaoBanco.ObterConexao())
                {

                string query = "INSERT INTO produtos (Nome, PrecoCusto, Precovenda) VALUES (@Nome, @PrecoCusto, @PrecoVenda)";
                conexao.Execute(query, new { produto.Nome, produto.PrecoCusto, produto.PrecoVenda });
                return true;
                };
            }
            catch (Exception erro)
            {
                throw new Exception($"Não foi possível gravar os dados: {erro.Message}");
            }
        }
    }

}
