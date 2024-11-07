namespace SistemaFazenda2
{
    partial class FormGestaoProdutos
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

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowHeadersWidth = 62;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(900, 462);
            this.dataGridViewProdutos.TabIndex = 0;
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(15, 492);
            this.txtPesquisaProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(448, 26);
            this.txtPesquisaProduto.TabIndex = 1;
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(480, 492);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(135, 38);
            this.btnBuscarProduto.TabIndex = 2;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(15, 554);
            this.btnAdicionarProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(150, 46);
            this.btnAdicionarProduto.TabIndex = 3;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(180, 554);
            this.btnEditarProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(150, 46);
            this.btnEditarProduto.TabIndex = 4;
            this.btnEditarProduto.Text = "Editar Produto";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(345, 554);
            this.btnExcluirProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(150, 46);
            this.btnExcluirProduto.TabIndex = 5;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // FormGestaoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 615);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.txtPesquisaProduto);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGestaoProdutos";
            this.Text = "Gestão de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
    }
}
