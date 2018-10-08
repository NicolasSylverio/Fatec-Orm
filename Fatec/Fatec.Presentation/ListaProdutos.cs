using Fatec.Dominio;
using Fatec.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatec.Presentation
{
    public partial class ListaProdutos : Form
    {
        public ListaProdutos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var crud = new CrudProduto();

            var produtos = crud.RetornarProdutos();

            dgvProdutos.DataSource = produtos;
        }
    }
}
