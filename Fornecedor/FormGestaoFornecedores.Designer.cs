using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace SistemaFazenda2
{
    partial class FormGestaoFornecedores
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
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditarFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.ColumnHeadersHeight = 34;
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(30, 69);
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.RowHeadersWidth = 62;
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(1175, 532);
            this.dataGridViewFornecedores.TabIndex = 0;
            this.dataGridViewFornecedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedores_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(30, 607);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(232, 65);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar Fornecedor";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // btnEditarFornecedor
            // 
            this.btnEditarFornecedor.Location = new System.Drawing.Point(410, 607);
            this.btnEditarFornecedor.Name = "btnEditarFornecedor";
            this.btnEditarFornecedor.Size = new System.Drawing.Size(232, 65);
            this.btnEditarFornecedor.TabIndex = 2;
            this.btnEditarFornecedor.Text = "Editar Fornecedor";
            this.btnEditarFornecedor.Click += new System.EventHandler(this.btnEditarFornecedor_Click);
            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(897, 607);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(232, 65);
            this.btnExcluirFornecedor.TabIndex = 3;
            this.btnExcluirFornecedor.Text = "Excluir Fornecedor";
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(30, 30);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(424, 26);
            this.txtPesquisa.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(495, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 39);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormGestaoFornecedores
            // 
            this.ClientSize = new System.Drawing.Size(1241, 685);
            this.Controls.Add(this.dataGridViewFornecedores);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnEditarFornecedor);
            this.Controls.Add(this.btnExcluirFornecedor);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FormGestaoFornecedores";
            this.Text = "Gestão de Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            private System.Windows.Forms.DataGridView dataGridViewFornecedores;
            private System.Windows.Forms.Button btnAdicionar;
            private System.Windows.Forms.Button btnEditarFornecedor;
            private System.Windows.Forms.Button btnExcluirFornecedor;
            private System.Windows.Forms.TextBox txtPesquisa;
            private System.Windows.Forms.Button btnBuscar;

            #endregion
    }
}
