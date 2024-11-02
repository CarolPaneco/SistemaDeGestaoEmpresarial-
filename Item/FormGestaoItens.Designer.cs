namespace SistemaFazenda2
{
    partial class FormGestaoItens
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
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();

            // dataGridViewItens
            this.dataGridViewItens.Location = new System.Drawing.Point(30, 30);
            this.dataGridViewItens.Size = new System.Drawing.Size(600, 250);

            // btnAdicionarItem
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.Location = new System.Drawing.Point(30, 300);
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);

            // btnEditarItem
            this.btnEditarItem.Text = "Editar Item";
            this.btnEditarItem.Location = new System.Drawing.Point(170, 300);
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);

            // btnExcluirItem
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.Location = new System.Drawing.Point(310, 300);
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);

            // FormGestaoItens
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.dataGridViewItens);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnExcluirItem);
            this.Text = "Gestão de Itens";
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItens;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnExcluirItem;
    }
}
