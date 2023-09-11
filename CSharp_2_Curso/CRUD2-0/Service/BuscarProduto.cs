using CRUD2_0.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD2_0.Service
{
    public class BuscarProduto
    {

        public IEnumerable<Produto> Buscar()
        {
            try
            {
                using (var conexao = ConexaoBanco.ObterConexao())
                {
                    string query = "SELECT Id, Nome, PrecoVenda, PrecoCusto  FROM Produtos";
                    var respota = conexao.Query<Produto>(query).ToList();


                    return respota;
                }


            }
            catch (Exception erro)
            {

                throw new Exception($"Ferrou  {erro.Message}");
            }
        }
    }
}
