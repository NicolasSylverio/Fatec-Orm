namespace Fatec.Entity._4_Dto
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Autorizacao { get; set; }
    }
}
