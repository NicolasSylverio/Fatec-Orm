using Fatec.Entity._1_Presentation;
using System;
using System.Windows.Forms;

namespace Fatec.Entity
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void listaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaUsuario form = new ListaUsuario();
            form.ShowDialog();
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarUsuario form = new CadastrarUsuario();
            form.ShowDialog();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente form = new CadastrarCliente();
            form.ShowDialog();
        }

        private void listaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCliente form = new ListaCliente();
            form.ShowDialog();
        }

        private void listaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProduto form = new ListaProduto();
            form.ShowDialog();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProduto form = new CadastrarProduto();
            form.ShowDialog();
        }

        private void alterarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarUsuario form = new AlterarUsuario();
            form.ShowDialog();
        }
    }
}
