namespace SistemaFazenda2
{
    partial class FormEstoque
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
        private System.Windows.Forms.Button btnAtualizar; // Se você adicionar o botão
        private System.Windows.Forms.Label labelTitle; // Se você adicionar o label

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
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(24, 100);
            this.dataGridViewEstoque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.RowHeadersWidth = 62;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(1286, 611);
            this.dataGridViewEstoque.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1069, 14);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(147, 57);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(51, 39);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(298, 32);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Estoque de Produtos";
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 837);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
