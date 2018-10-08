namespace Fatec.Entity
{
    partial class ListaUsuario
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.lblListaCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(67, 380);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 35);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(413, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 35);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(67, 77);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.Size = new System.Drawing.Size(482, 281);
            this.dtgUsuario.TabIndex = 2;
            // 
            // lblListaCliente
            // 
            this.lblListaCliente.AutoSize = true;
            this.lblListaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCliente.Location = new System.Drawing.Point(40, 35);
            this.lblListaCliente.Name = "lblListaCliente";
            this.lblListaCliente.Size = new System.Drawing.Size(116, 24);
            this.lblListaCliente.TabIndex = 3;
            this.lblListaCliente.Text = "Lista Usuario";
            // 
            // ListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.lblListaCliente);
            this.Controls.Add(this.dtgUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnBuscar);
            this.Name = "ListaUsuario";
            this.Text = "Lista Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.Label lblListaCliente;
    }
}