using System.Windows.Forms;

namespace Fatec.Presentation
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new CadastroCliente();
            form.ShowDialog();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var form = new CadastroProduto();
            form.ShowDialog();
        }

        private void listaToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            var form = new ListaClientes();
            form.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new ListaProdutos();
            form.ShowDialog();
        }

        private void cadastroToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            var form = new CadastroUsuario();
            form.ShowDialog();
        }

        private void listaToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var form = new ListaUsuario();
        }
    }
}
