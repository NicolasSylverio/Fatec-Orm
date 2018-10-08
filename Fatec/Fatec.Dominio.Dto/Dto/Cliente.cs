using System;

namespace Fatec.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
    }
}
