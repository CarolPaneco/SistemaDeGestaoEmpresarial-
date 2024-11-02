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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();

            // lblNome
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new System.Drawing.Point(20, 20);

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(100, 20);

            // lblPreco
            this.lblPreco.Text = "Preço:";
            this.lblPreco.Location = new System.Drawing.Point(20, 60);

            // txtPreco
            this.txtPreco.Location = new System.Drawing.Point(100, 60);

            // btnSalvar
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(100, 100);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // FormAdicionarProduto
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnSalvar);
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Text = "Adicionar Produto";
        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
    }
}
