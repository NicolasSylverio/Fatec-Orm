using Fatec.Dominio;
using Fatec.Dominio.CrossCutting;
using Fatec.Dominio.Servicos;
using System;
using System.Windows.Forms;

namespace Fatec.Presentation
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var produto = new Produto
                {
                    Descricao = txtDescricao.Text,
                    Marca = txtMarca.Text,
                    Preco = Format.FormatarMaskedTextBoxDecimal(txtPreco.Text),
                    Quantidade = Format.FormatarMaskedTextBoxInt(txtQuantidade.Text)
                };

                var crud = new CrudProduto();

                crud.CadastrarProduto(produto);

                MessageBox.Show("Produto cadastrado com sucesso", "Informação Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Cadastrar Produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
