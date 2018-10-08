using Fatec.Entity._2_Dominio;
using Fatec.Entity._4_Dto;
using Fatec.Entity._6_Formatacao;
using System;
using System.Windows.Forms;

namespace Fatec.Entity._1_Presentation
{
    public partial class AlterarUsuario : Form
    {
        public AlterarUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimparTela()
        {
            txtLogin.Text = "";
            txtNome.Text = "";
            txtAutorizacao.Text = "";
            txtSenha.Text = "";
        }

        private void AlterarUsuario_Load(object sender, EventArgs e)
        {
            UsuarioDominio dominio = new UsuarioDominio();

            dtgUsuario.DataSource = dominio.RetornarUsuario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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

                UsuarioDominio dominio = new UsuarioDominio();

                dominio.AlterarUsuario(usuario);

                LimparTela();

                MessageBox.Show("Usuario Cadastrado com Sucesso", "Informação Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Cadastrar Usuario, Erro: {ex.Message}", "Erro Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgUsuario_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
