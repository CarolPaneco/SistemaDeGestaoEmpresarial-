namespace SistemaVenda
{
    partial class FormSelecionarCliente
    {
        /// <summary>
        /// Variáveis necessárias para o designer
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpeza de todos os recursos usados
        /// </summary>
        /// <param name="disposing">True se os recursos gerenciados devem ser descartados; caso contrário, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para o Designer - não modifique
        /// o conteúdo do método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 20;
            this.listBoxClientes.Location = new System.Drawing.Point(12, 12);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(250, 144);
            this.listBoxClientes.TabIndex = 0;
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Location = new System.Drawing.Point(12, 168);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(150, 40);
            this.btnSelecionarCliente.TabIndex = 1;
            this.btnSelecionarCliente.Text = "Selecionar Cliente";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click_1);
            // 
            // FormSelecionarCliente
            // 
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.listBoxClientes);
            this.Name = "FormSelecionarCliente";
            this.Text = "Selecionar Cliente";
            this.Load += new System.EventHandler(this.FormSelecionarCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button btnSelecionarCliente;
    }
}
