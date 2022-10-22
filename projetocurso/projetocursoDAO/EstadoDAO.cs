using Npgsql;
using projetocursoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetocursoDAO
{
    public class EstadoDAO
    {

        string conexao_postgre = @"Server=172.17.0.1;
                                   Port=5432;
                                   User id=postgres;
                                   Password=postdba;
                                   Database=bdcurso";

        NpgsqlConnection conexao;

        public EstadoDAO()
        {
            conexao = new NpgsqlConnection(conexao_postgre);
        }

        public Boolean cadastrar(Estado objEstado)
        {
            Boolean retorno = false;
            try
            {
                if(objEstado.idEstado == 0)
                {
                    retorno = this.inserir(objEstado);
                }
                else
                {
                    retorno = this.alterar(objEstado);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public Boolean inserir(Estado objEstado)
        {
            Boolean retorno = false;
            try
            {
                NpgsqlCommand sql = new NpgsqlCommand("insert into estado (nomeestado, siglaestado) " +
                                                      "values (@nomeestado,@siglaestado)", conexao);

                sql.Parameters.AddWithValue("@nomeestado", objEstado.nomeEstado);
                sql.Parameters.AddWithValue("@siglaestado", objEstado.siglaEstado);

                conexao.Open( );
                sql.ExecuteNonQuery( );
                retorno = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close( );
            }
            return retorno;
        }

        public Boolean alterar(Estado objEstado)
        {
            Boolean retorno = false;
            try
            {
                NpgsqlCommand sql = new NpgsqlCommand("update estado set nomeestado=@nomeestado, " +
                                                        "siglaestado=@siglaestado " +
                                                        "where idestado=@idestado", conexao);

                sql.Parameters.AddWithValue("@idestado", objEstado.idEstado);
                sql.Parameters.AddWithValue("@nomeestado", objEstado.nomeEstado);
                sql.Parameters.AddWithValue("@siglaestado", objEstado.siglaEstado);

                conexao.Open( );
                sql.ExecuteNonQuery( );
                retorno = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close( );
            }
            return retorno;
        }

        public Boolean excluir(int idEstado)
        {
            Boolean retorno = false;
            try
            {
                NpgsqlCommand sql = new NpgsqlCommand("DELETE FROM  estado (nomeestado, siglaestado) " +
                                                    "WHERE idestado = @idestado", conexao);

                sql.Parameters.AddWithValue("@idestado", idEstado);

                conexao.Open( );
                sql.ExecuteNonQuery( );
                retorno = true;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close( );
            }

            return retorno;
        }

        public Estado carregar(int idEstado)
        {
            try
            {
                NpgsqlCommand sql = new NpgsqlCommand("SELECT * FROM estado " +
                    "WHERE isestado = @id", conexao);

                sql.Parameters.AddWithValue("@id", idEstado);
                conexao.Open( );

                Estado oEstado = new Estado( );
                NpgsqlDataReader datareader;
                datareader = sql.ExecuteReader( );
                while(datareader.Read( ))
                {
                    oEstado.idEstado =
                        Convert.ToInt32(datareader["idestado"]);
                    oEstado.nomeEstado = datareader["nomeestado"].ToString( );
                    oEstado.siglaEstado = datareader["siglaestado"].ToString( );
                }
                return oEstado;

            }
            catch(NpgsqlException erro)
            {
                throw erro;
            }
            finally
            {

            }

        }

        private List<Estado> TransformaReaderEmListaDeObjeto(NpgsqlDataReader retornoDataRaader)
        {
            var lstEstado = new List<Estado>;
            while(retornoDataRaader.Read( ))
            {
                var temObjeto = new Estado( )
                {
                    idEstado = int.Parse(retornoDataRaader["idestado"].ToString( )),
                    nomeEstado = retornoDataRaader["nomeestado"].ToString( ),
                    siglaEstado = retornoDataRaader["silgaestado"].ToString( )
                };

                lstEstado.Add(temObjeto);
            }
            retornoDataRaader.Close( );
            return lstEstado;
        }

        private List<Estado> listar()
        {
            var lstEstado = new List<Estado>( );
            try
            {
                NpgsqlCommand sql = new NpgsqlCommand("SELECT * FROM estado ", conexao);

                NpgsqlDataReader datareader;
                datareader = sql.ExecuteReader( );
                lstEstado = TransformaReaderEmListaDeObjeto(datareader);
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close( );
            }
            return lstEstado;
        }
    }
}
