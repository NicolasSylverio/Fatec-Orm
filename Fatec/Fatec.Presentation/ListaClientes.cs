using Fatec.Dominio.Servicos;
using System;
using System.Windows.Forms;

namespace Fatec.Presentation
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CrudCliente crud = new CrudCliente();

            dgvClientes.DataSource = crud.RetornarClientes();
        }
    }
}
