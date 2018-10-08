using Fatec.Dominio;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Fatec.Infra
{
    public class CrudClienteAdoNet
    {
        public DataSet GetCliente()
        {
            SqlConnection conn = new SqlConnection(Conexao.connectionString);

            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Fatec].[dbo].[Cliente]", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool CadastrarCliente(Cliente cliente)
        {
            SqlConnection conexaoSql = new SqlConnection(Conexao.connectionString);
            SqlDataReader reader = null;
            try
            {
                conexaoSql.Open();

                SqlCommand comando = conexaoSql.CreateCommand();

                comando.CommandText = @"INSERT INTO Cliente
                                           ([Cpf]
                                           ,[Nome]
                                           ,[DataNascimento]
                                           ,[Endereco]
                                           ,[Cidade])
                                     VALUES
                                           (
                                             @cpf
                                            ,@nome
                                            ,@dataNascimento
                                            ,@endereco
                                            ,@cidade
                                           )";

                SqlParameter param1 = new SqlParameter("@cpf", cliente.Cpf);
                SqlParameter param2 = new SqlParameter("@nome", cliente.Nome);
                SqlParameter param3 = new SqlParameter("@dataNascimento", cliente.DataNascimento);
                SqlParameter param4 = new SqlParameter("@endereco", cliente.Endereco);
                SqlParameter param5 = new SqlParameter("@cidade", cliente.Cidade);

                comando.Parameters.Add(param1);
                comando.Parameters.Add(param2);
                comando.Parameters.Add(param3);
                comando.Parameters.Add(param4);
                comando.Parameters.Add(param5);

                reader = comando.ExecuteReader();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
                conexaoSql.Close();
            }
        }
    }
}
