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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox(); // Caixa de texto para pesquisa
            this.btnBuscarProduto = new System.Windows.Forms.Button(); // Botão para buscar

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeight = 34;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(30, 70); // Ajuste a posição
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersWidth = 62;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewProdutos.TabIndex = 0;

            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(30, 330);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(199, 35);
            this.btnAdicionarProduto.TabIndex = 1;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);

            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(262, 330);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(202, 35);
            this.btnEditarProduto.TabIndex = 2;
            this.btnEditarProduto.Text = "Editar Produto";
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);

            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(488, 330);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(176, 35);
            this.btnExcluirProduto.TabIndex = 3;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);

            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(30, 30); // Posição da caixa de texto
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(400, 20);
            this.txtPesquisaProduto.TabIndex = 4;

            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(450, 28); // Posição do botão de busca
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProduto.TabIndex = 5;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);

            // 
            // FormGestaoProdutos
            // 
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.txtPesquisaProduto);
            this.Controls.Add(this.btnBuscarProduto);
            this.Name = "FormGestaoProdutos";
            this.Text = "Gestão de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.TextBox txtPesquisaProduto; // Caixa de texto para pesquisa
        private System.Windows.Forms.Button btnBuscarProduto; // Botão para buscar
    }
}
