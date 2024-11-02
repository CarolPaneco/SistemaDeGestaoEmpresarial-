namespace SistemaFazenda2
{
    partial class FormAdicionarVenda
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtProdutoId = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();

            // Configuração dos campos de texto
            this.SuspendLayout();

            // txtProdutoId
            this.txtProdutoId.Location = new System.Drawing.Point(100, 20);
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.Size = new System.Drawing.Size(150, 23);
            this.txtProdutoId.Text = "ID do Produto";
            this.txtProdutoId.ForeColor = System.Drawing.Color.Gray;
            this.txtProdutoId.Enter += new System.EventHandler(this.txtProdutoId_Enter);
            this.txtProdutoId.Leave += new System.EventHandler(this.txtProdutoId_Leave);

            // txtQuantidade
            this.txtQuantidade.Location = new System.Drawing.Point(100, 60);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(150, 23);
            this.txtQuantidade.Text = "Quantidade";
            this.txtQuantidade.ForeColor = System.Drawing.Color.Gray;
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);

            // txtPrecoTotal
            this.txtPrecoTotal.Location = new System.Drawing.Point(100, 100);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(150, 23);
            this.txtPrecoTotal.Text = "Preço Total";
            this.txtPrecoTotal.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecoTotal.Enter += new System.EventHandler(this.txtPrecoTotal_Enter);
            this.txtPrecoTotal.Leave += new System.EventHandler(this.txtPrecoTotal_Leave);

            // txtClienteId
            this.txtClienteId.Location = new System.Drawing.Point(100, 140);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(150, 23);
            this.txtClienteId.Text = "ID do Cliente";
            this.txtClienteId.ForeColor = System.Drawing.Color.Gray;
            this.txtClienteId.Enter += new System.EventHandler(this.txtClienteId_Enter);
            this.txtClienteId.Leave += new System.EventHandler(this.txtClienteId_Leave);

            // btnSalvar
            this.btnSalvar.Location = new System.Drawing.Point(100, 180);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 30);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // FormAdicionarVenda
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.txtProdutoId);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FormAdicionarVenda";
            this.Text = "Adicionar Venda";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtProdutoId;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Button btnSalvar;
    }
}
