using Fatec.Infra;
using System.Collections.Generic;

namespace Fatec.Dominio.Servicos
{
    public class CrudProduto
    {

        public void CadastrarProduto(Produto produto)
        {
            var crud = new CrudProdutoDapper();

            crud.CadastrarProduto(produto);
        }

        public IEnumerable<Produto> RetornarProdutos()
        {
            var crud = new CrudProdutoDapper();

            return crud.RetornarProdutos();
        }
    }
}
