using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fatec.Entity._4_Dto
{
    [Table("Vendas")]
    public class Venda
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public DateTime DataVenda { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
