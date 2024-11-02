using System;

namespace SistemaFazenda2
{
    partial class FormGestaoVenda
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
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.btnAdicionarVenda = new System.Windows.Forms.Button();
            this.btnEditarVenda = new System.Windows.Forms.Button();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            this.txtBuscarVenda = new System.Windows.Forms.TextBox();
            this.btnBuscarVenda = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.Size = new System.Drawing.Size(776, 322);
            this.dataGridViewVendas.TabIndex = 0;

            // 
            // txtBuscarVenda
            // 
            this.txtBuscarVenda.Location = new System.Drawing.Point(12, 12);
            this.txtBuscarVenda.Name = "txtBuscarVenda";
            this.txtBuscarVenda.Size = new System.Drawing.Size(200, 20);
            this.txtBuscarVenda.TabIndex = 4;

            // 
            // btnBuscarVenda
            // 
            this.btnBuscarVenda.Location = new System.Drawing.Point(218, 10);
            this.btnBuscarVenda.Name = "btnBuscarVenda";
            this.btnBuscarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVenda.TabIndex = 5;
            this.btnBuscarVenda.Text = "Buscar";
            this.btnBuscarVenda.UseVisualStyleBackColor = true;
            this.btnBuscarVenda.Click += new System.EventHandler(this.btnBuscarVenda_Click);

            // 
            // btnAdicionarVenda
            // 
            this.btnAdicionarVenda.Location = new System.Drawing.Point(12, 388);
            this.btnAdicionarVenda.Name = "btnAdicionarVenda";
            this.btnAdicionarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarVenda.TabIndex = 1;
            this.btnAdicionarVenda.Text = "Adicionar";
            this.btnAdicionarVenda.UseVisualStyleBackColor = true;
            this.btnAdicionarVenda.Click += new System.EventHandler(this.btnAdicionarVenda_Click);

            // 
            // btnEditarVenda
            // 
            this.btnEditarVenda.Location = new System.Drawing.Point(93, 388);
            this.btnEditarVenda.Name = "btnEditarVenda";
            this.btnEditarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnEditarVenda.TabIndex = 2;
            this.btnEditarVenda.Text = "Editar";
            this.btnEditarVenda.UseVisualStyleBackColor = true;
            this.btnEditarVenda.Click += new System.EventHandler(this.btnEditarVenda_Click);

            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.Location = new System.Drawing.Point(174, 388);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirVenda.TabIndex = 3;
            this.btnExcluirVenda.Text = "Excluir";
            this.btnExcluirVenda.UseVisualStyleBackColor = true;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);

            // 
            // FormGestaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarVenda);
            this.Controls.Add(this.txtBuscarVenda);
            this.Controls.Add(this.btnExcluirVenda);
            this.Controls.Add(this.btnEditarVenda);
            this.Controls.Add(this.btnAdicionarVenda);
            this.Controls.Add(this.dataGridViewVendas);
            this.Name = "FormGestaoVenda";
            this.Text = "Gestão de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.Button btnAdicionarVenda;
        private System.Windows.Forms.Button btnEditarVenda;
        private System.Windows.Forms.Button btnExcluirVenda;
        private System.Windows.Forms.TextBox txtBuscarVenda;
        private System.Windows.Forms.Button btnBuscarVenda;
    }
}
