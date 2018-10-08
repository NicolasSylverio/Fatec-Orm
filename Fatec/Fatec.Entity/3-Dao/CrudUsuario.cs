using Fatec.Entity._4_Dto;
using Fatec.Entity._5_Infra;
using System.Collections.Generic;
using System.Linq;

namespace Fatec.Entity._3_Dao
{
    public class CrudUsuario
    {
        private readonly Contexto _contexto;

        public CrudUsuario()
        {
            _contexto = new Contexto();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
            _contexto.SaveChanges();
        }

        public List<Usuario> RetornarUsuario()
        {
            return _contexto.Usuario.ToList();
        }

        public void AlterarUsuario(Usuario usuario)
        {

            var teste = _contexto.Usuario.FirstOrDefault(x => x.Id == usuario.Id);

            if (teste != null)
            {
                teste.Nome = usuario.Nome;
                teste.Login = usuario.Login;
                teste.Senha = usuario.Senha;
                teste.Autorizacao = usuario.Autorizacao;
            }

            _contexto.SaveChanges();
        }
    }
}
