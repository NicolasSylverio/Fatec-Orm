using Fatec.Entity._3_Dao;
using Fatec.Entity._4_Dto;
using System.Collections.Generic;

namespace Fatec.Entity._2_Dominio
{
    public class UsuarioDominio
    {
        private readonly CrudUsuario _crudUsuario;

        public UsuarioDominio()
        {
            _crudUsuario = new CrudUsuario();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            _crudUsuario.CadastrarUsuario(usuario);
        }

        public List<Usuario> RetornarUsuario()
        {
            return _crudUsuario.RetornarUsuario();
        }

        public void AlterarUsuario(Usuario usuario)
        {
            _crudUsuario.AlterarUsuario(usuario);
        }
    }
}