namespace Fatec.Entity
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroClienteToolStripMenuItem,
            this.listaClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // listaClienteToolStripMenuItem
            // 
            this.listaClienteToolStripMenuItem.Name = "listaClienteToolStripMenuItem";
            this.listaClienteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listaClienteToolStripMenuItem.Text = "Lista Cliente";
            this.listaClienteToolStripMenuItem.Click += new System.EventHandler(this.listaClienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.listaProdutoToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // listaProdutoToolStripMenuItem
            // 
            this.listaProdutoToolStripMenuItem.Name = "listaProdutoToolStripMenuItem";
            this.listaProdutoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listaProdutoToolStripMenuItem.Text = "Lista Produto";
            this.listaProdutoToolStripMenuItem.Click += new System.EventHandler(this.listaProdutoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuarioToolStripMenuItem,
            this.listaUsuarioToolStripMenuItem,
            this.alterarUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cadastrarUsuarioToolStripMenuItem
            // 
            this.cadastrarUsuarioToolStripMenuItem.Name = "cadastrarUsuarioToolStripMenuItem";
            this.cadastrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarUsuarioToolStripMenuItem.Text = "Cadastrar Usuario";
            this.cadastrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuarioToolStripMenuItem_Click);
            // 
            // listaUsuarioToolStripMenuItem
            // 
            this.listaUsuarioToolStripMenuItem.Name = "listaUsuarioToolStripMenuItem";
            this.listaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaUsuarioToolStripMenuItem.Text = "Lista Usuario";
            this.listaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.listaUsuarioToolStripMenuItem_Click);
            // 
            // alterarUsuarioToolStripMenuItem
            // 
            this.alterarUsuarioToolStripMenuItem.Name = "alterarUsuarioToolStripMenuItem";
            this.alterarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarUsuarioToolStripMenuItem.Text = "Alterar Usuario";
            this.alterarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.alterarUsuarioToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarUsuarioToolStripMenuItem;
    }
}