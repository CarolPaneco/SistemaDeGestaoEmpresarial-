namespace SistemaFazenda2
{
    partial class FormCompras
    {
        /// <summary>
        /// Requer designer do Windows Forms - não modifique
        /// o conteúdo deste arquivo com o editor de código.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpa os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
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
        /// Método necessário para o Designer — não modifique
        /// o conteúdo do método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.comboBoxFornecedores = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItens
            // 
            this.dataGridViewItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItens.Location = new System.Drawing.Point(16, 135);
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.RowHeadersWidth = 62;
            this.dataGridViewItens.Size = new System.Drawing.Size(776, 200);
            this.dataGridViewItens.TabIndex = 0;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(658, 94);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(120, 35);
            this.btnAdicionarItem.TabIndex = 1;
            this.btnAdicionarItem.Text = "Adicionar Produto";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Location = new System.Drawing.Point(658, 350);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(134, 35);
            this.btnRegistrarCompra.TabIndex = 2;
            this.btnRegistrarCompra.Text = "Registrar Compra";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(88, 14);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(240, 28);
            this.comboBoxProduto.TabIndex = 3;
            // 
            // comboBoxFornecedores
            // 
            this.comboBoxFornecedores.FormattingEnabled = true;
            this.comboBoxFornecedores.Location = new System.Drawing.Point(101, 42);
            this.comboBoxFornecedores.Name = "comboBoxFornecedores";
            this.comboBoxFornecedores.Size = new System.Drawing.Size(240, 28);
            this.comboBoxFornecedores.TabIndex = 4;
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(127, 72);
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownQuantidade.TabIndex = 5;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(13, 15);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(69, 20);
            this.lblProduto.TabIndex = 6;
            this.lblProduto.Text = "Produto:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(13, 74);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(13, 45);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(95, 20);
            this.lblFornecedor.TabIndex = 8;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // FormCompras
            // 
            this.ClientSize = new System.Drawing.Size(804, 401);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.comboBoxFornecedores);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.dataGridViewItens);
            this.Name = "FormCompras";
            this.Text = "Formulário de Compras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItens;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.ComboBox comboBoxFornecedores;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblFornecedor;
    }
}
