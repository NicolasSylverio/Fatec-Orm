namespace Fatec.Entity._1_Presentation
{
    partial class AlterarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAutorizacao = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAutorizacao = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAutorizacao
            // 
            this.txtAutorizacao.Location = new System.Drawing.Point(628, 251);
            this.txtAutorizacao.Mask = "0";
            this.txtAutorizacao.Name = "txtAutorizacao";
            this.txtAutorizacao.Size = new System.Drawing.Size(221, 20);
            this.txtAutorizacao.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(628, 191);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(221, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(628, 135);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(221, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(628, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblAutorizacao
            // 
            this.lblAutorizacao.AutoSize = true;
            this.lblAutorizacao.Location = new System.Drawing.Point(625, 234);
            this.lblAutorizacao.Name = "lblAutorizacao";
            this.lblAutorizacao.Size = new System.Drawing.Size(63, 13);
            this.lblAutorizacao.TabIndex = 7;
            this.lblAutorizacao.Text = "Autorização";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(625, 175);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(625, 119);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(625, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(756, 299);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(628, 299);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(28, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(158, 24);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Alteração Usuario";
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(32, 60);
            this.dtgUsuario.MultiSelect = false;
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuario.Size = new System.Drawing.Size(541, 278);
            this.dtgUsuario.StandardTab = true;
            this.dtgUsuario.TabIndex = 1;
            this.dtgUsuario.DoubleClick += new System.EventHandler(this.dtgUsuario_DoubleClick);
            // 
            // AlterarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 380);
            this.ControlBox = false;
            this.Controls.Add(this.dtgUsuario);
            this.Controls.Add(this.txtAutorizacao);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblAutorizacao);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblUsuario);
            this.Name = "AlterarUsuario";
            this.Text = "AlterarUsuario";
            this.Load += new System.EventHandler(this.AlterarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtAutorizacao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAutorizacao;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dtgUsuario;
    }
}