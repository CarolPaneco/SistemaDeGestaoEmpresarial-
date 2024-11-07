namespace SistemaFazenda2
{
    partial class FormAdicionarProduto1
    {
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.DataGridView dataGridViewItens;
        private System.Windows.Forms.Button btnRealizarVenda;

        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.FormAdicionarProduto1_Load);

            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.btnRealizarVenda = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            this.SuspendLayout();

            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.Location = new System.Drawing.Point(20, 20);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(200, 150);
            this.listBoxProdutos.TabIndex = 0;

            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(240, 20);
            this.numericUpDownQuantidade.Minimum = 1;
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownQuantidade.TabIndex = 1;
            this.numericUpDownQuantidade.Value = 1;

            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(240, 60);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(100, 30);
            this.btnAdicionarItem.TabIndex = 2;
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);

            // 
            // dataGridViewItens
            // 
            this.dataGridViewItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItens.Location = new System.Drawing.Point(20, 200);
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.Size = new System.Drawing.Size(450, 150);
            this.dataGridViewItens.TabIndex = 3;

            // 
            // btnRealizarVenda
            // 
            this.btnRealizarVenda.Location = new System.Drawing.Point(20, 370);
            this.btnRealizarVenda.Name = "btnRealizarVenda";
            this.btnRealizarVenda.Size = new System.Drawing.Size(150, 30);
            this.btnRealizarVenda.TabIndex = 4;
            this.btnRealizarVenda.Text = "Realizar Venda";
            this.btnRealizarVenda.UseVisualStyleBackColor = true;
            this.btnRealizarVenda.Click += new System.EventHandler(this.btnRealizarVenda_Click);

            // 
            // FormAdicionarProduto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.dataGridViewItens);
            this.Controls.Add(this.btnRealizarVenda);
            this.Name = "FormAdicionarProduto1";
            this.Text = "Adicionar Produto";

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
