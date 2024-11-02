namespace SistemaFazenda2
{
    partial class FormEditarItem
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
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(100, 20);

            // txtQuantidade
            this.txtQuantidade.Location = new System.Drawing.Point(100, 60);

            // txtPreco
            this.txtPreco.Location = new System.Drawing.Point(100, 100);

            // btnSalvar
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new System.Drawing.Point(100, 140);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // lblNome
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new System.Drawing.Point(20, 20);

            // lblQuantidade
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.Location = new System.Drawing.Point(20, 60);

            // lblPreco
            this.lblPreco.Text = "Preço:";
            this.lblPreco.Location = new System.Drawing.Point(20, 100);

            // FormEditarItem
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Text = "Editar Item";
        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPreco;
    }
}
