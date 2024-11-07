namespace SistemaFazenda2
{
    partial class FormAdicionarProduto
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 38);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(373, 26);
            this.txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(22, 100);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(148, 26);
            this.txtPreco.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(22, 186);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(373, 90);
            this.txtDescricao.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(22, 300);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 35);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(22, 14);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome:";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(22, 75);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(54, 20);
            this.labelPreco.TabIndex = 6;
            this.labelPreco.Text = "Preço:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(22, 147);
            this.labelDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(84, 20);
            this.labelDescricao.TabIndex = 8;
            this.labelDescricao.Text = "Descrição:";
            // 
            // FormAdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 364);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdicionarProduto";
            this.Text = "Adicionar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelDescricao;
    }

}
