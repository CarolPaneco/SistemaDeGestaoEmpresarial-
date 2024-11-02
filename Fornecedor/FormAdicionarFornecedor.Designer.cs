namespace SistemaFazenda2
{
    partial class FormAdicionarFornecedor
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCnpjCpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSalvar;

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCnpjCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;

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
            this.txtCnpjCpf = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();

            // Inicializando Labels
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCnpjCpf = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(120, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 0;

            // lblNome
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";

            // txtCnpjCpf
            this.txtCnpjCpf.Location = new System.Drawing.Point(120, 70);
            this.txtCnpjCpf.Name = "txtCnpjCpf";
            this.txtCnpjCpf.Size = new System.Drawing.Size(200, 20);
            this.txtCnpjCpf.TabIndex = 1;

            // lblCnpjCpf
            this.lblCnpjCpf.AutoSize = true;
            this.lblCnpjCpf.Location = new System.Drawing.Point(30, 73);
            this.lblCnpjCpf.Name = "lblCnpjCpf";
            this.lblCnpjCpf.Size = new System.Drawing.Size(53, 13);
            this.lblCnpjCpf.TabIndex = 7;
            this.lblCnpjCpf.Text = "CNPJ/CPF:";

            // txtEndereco
            this.txtEndereco.Location = new System.Drawing.Point(120, 110);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 2;

            // lblEndereco
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(30, 113);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(55, 13);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço:";

            // txtTelefone
            this.txtTelefone.Location = new System.Drawing.Point(120, 150);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(200, 20);
            this.txtTelefone.TabIndex = 3;

            // lblTelefone
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(30, 153);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 4;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 193);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail:";

            // btnSalvar
            this.btnSalvar.Location = new System.Drawing.Point(120, 230);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 30);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // FormAdicionarFornecedor
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCnpjCpf);
            this.Controls.Add(this.txtCnpjCpf);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FormAdicionarFornecedor";
            this.Text = "Adicionar Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
