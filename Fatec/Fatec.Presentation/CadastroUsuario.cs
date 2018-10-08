using Fatec.Dominio.CrossCutting;
using Fatec.Dominio.Dto.Dto;
using Fatec.Dominio.Services;
using System;
using System.Windows.Forms;

namespace Fatec.Presentation
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
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
                var usuario = new Usuario()
                {
                    Nome = txtNome.Text,
                    Login = txtLogin.Text,
                    Senha = txtSenha.Text,
                    Autorizacao = Format.FormatarMaskedTextBoxInt(txtAutorizacao.Text)
                };

                CrudUsuario crud = new CrudUsuario();

                crud.CadastrarUsuario(usuario);

                MessageBox.Show("Usuario Cadastrado", "Informação do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Problema ao cadastrar usuario: {ex.Message}", "Erro Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
