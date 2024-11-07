namespace SistemaFazenda2
{
    partial class FormRelatorioVendas
    {
        private System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.Label lblTotalItens;
        private System.Windows.Forms.Label lblValorTotal;

        private void InitializeComponent()
        {
            this.lblTotalItens = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.AutoSize = true;
            this.lblTotalItens.Location = new System.Drawing.Point(30, 400); // Ajuste a posição conforme necessário
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(140, 13);
            this.lblTotalItens.TabIndex = 0;
            this.lblTotalItens.Text = "Total de Itens Vendidos: 0";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(30, 420); // Ajuste a posição conforme necessário
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(140, 13);
            this.lblValorTotal.TabIndex = 1;
            this.lblValorTotal.Text = "Valor Total Vendido: R$ 0,00";
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewVendas.TabIndex = 0;

            // 
            // FormRelatorioVendas
            // 
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.dataGridViewVendas);
            this.Controls.Add(this.lblTotalItens);
            this.Controls.Add(this.lblValorTotal);
            this.Name = "FormRelatorioVendas";
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.FormRelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
