using Fatec.Entity._4_Dto;
using Fatec.Entity._6_Formatacao;
using System;
using System.Windows.Forms;

namespace Fatec.Entity._1_Presentation
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Nome = txtNome.Text,
                Cidade = txtCidade.Text,
                Endereco = txtEndereco.Text,
                Cpf = Format.FormatarMaskedTextBoxString(txtCpf.Text)
            };

            
        }
    }
}
