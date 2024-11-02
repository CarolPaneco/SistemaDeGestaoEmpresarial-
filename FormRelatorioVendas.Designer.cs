namespace SistemaFazenda2
{
    partial class FormRelatorioVendas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewRelatorio;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label lblTotalItensVendidos;
        private System.Windows.Forms.Label lblReceitaTotal;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;

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
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.lblTotalItensVendidos = new System.Windows.Forms.Label();
            this.lblReceitaTotal = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();

            // Configuração do DataGridView
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(30, 80);
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(600, 300);

            // Configuração dos labels de totais
            this.lblTotalVendas.Location = new System.Drawing.Point(30, 400);
            this.lblTotalVendas.Text = "Total de Vendas: ";

            this.lblTotalItensVendidos.Location = new System.Drawing.Point(200, 400);
            this.lblTotalItensVendidos.Text = "Total de Itens Vendidos: ";

            this.lblReceitaTotal.Location = new System.Drawing.Point(400, 400);
            this.lblReceitaTotal.Text = "Receita Total: ";

            // Botão Filtrar
            this.btnFiltrar.Location = new System.Drawing.Point(500, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 30);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);

            // DateTimePickers para filtro de data
            this.dtpInicio.Location = new System.Drawing.Point(30, 30);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.ShowCheckBox = true;

            this.dtpFim.Location = new System.Drawing.Point(250, 30);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(200, 22);
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.ShowCheckBox = true;

            // Adicionar controles ao formulário
            this.Controls.Add(this.dataGridViewRelatorio);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.lblTotalItensVendidos);
            this.Controls.Add(this.lblReceitaTotal);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFim);

            // Configurações do formulário
            this.Text = "Relatório de Vendas";
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Load += new System.EventHandler(this.FormRelatorioVendas_Load);
        }
    }
}
