using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace CRUD2_0
{
    public static class ConexaoBanco
    {

        private static IDbConnection _conexao;

        public static IDbConnection ObterConexao()
        {
            if (_conexao == null)
            {
                _conexao = new SqlConnection("Data Source=GARCIA-DELLG15\\SQLEXPRESS;Initial Catalog=CRUD_Basico;Integrated Security=True");
                //_conexao = new NpgsqlConnection("Host=containers-us-west-43.railway.app;Port=7045;Database=railway;Username=postgres;Password=63DxkT3cfLsOtNpLnq39;");
            }

            return _conexao;
        }
    }
}
