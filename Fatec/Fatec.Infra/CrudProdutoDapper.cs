using Dapper;
using Fatec.Dominio;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Fatec.Infra
{
    public class CrudProdutoDapper
    {
        public void CadastrarProduto(Produto produto)
        {
            using (var conexao = new SqlConnection(Conexao.connectionString))
            {
                conexao.Execute
                    ( @"
                        INSERT INTO [dbo].[Produto]
                               ([Descricao]
                               ,[Marca]
                               ,[Preco]
                               ,[Quantidade])
                         VALUES
                               (@descricao
                               ,@marca
                               ,@preco
                               ,@quantidade)", new { descricao = produto.Descricao, marca = produto.Marca, preco = produto.Preco, quantidade = produto.Quantidade }
                    );
            }
        }

        public IEnumerable<Produto> RetornarProdutos()
        {
            using (var conexao = new SqlConnection(Conexao.connectionString))
            {
                return conexao.Query<Produto>("Select * from Fatec.dbo.Produto");
            }
        }
    }
}
