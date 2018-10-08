namespace Fatec.Entity._4_Dto
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
