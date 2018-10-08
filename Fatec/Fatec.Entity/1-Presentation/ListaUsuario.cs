using Fatec.Entity._2_Dominio;
using System;
using System.Windows.Forms;

namespace Fatec.Entity
{
    public partial class ListaUsuario : Form
    {
        public ListaUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            UsuarioDominio crud = new UsuarioDominio();

            dtgUsuario.DataSource = crud.RetornarUsuario();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
