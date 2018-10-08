using Fatec.Dominio;
using Fatec.Dominio.CrossCutting;
using Fatec.Dominio.Servicos;
using System;
using System.Windows.Forms;

namespace Fatec.Presentation
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var cpf = Format.FormatarMaskedTextBoxString(txtCpf.Text);

                if (!string.IsNullOrWhiteSpace(cpf))
                {
                    Cliente cliente = new Cliente
                    {
                        Cpf = cpf,
                        Nome = txtNome.Text,
                        DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text),
                        Endereco = txtEndereco.Text,
                        Cidade = txtCidade.Text
                    };

                    CrudCliente crud = new CrudCliente();

                    var resultado = crud.CadastrarCliente(cliente);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Cpf Invalido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar Cliente {ex.Message}", "Erro Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
