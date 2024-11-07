namespace SistemaFazenda2
{
    partial class FormPrincipal
    {
        private System.Windows.Forms.Button btnEstoque;

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGerenciarFornecedores;
        private System.Windows.Forms.Button btnGerenciarProdutos;
        private System.Windows.Forms.Button btnGerenciarClientes;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCompras;
        

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
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnGerenciarFornecedores = new System.Windows.Forms.Button();
            this.btnGerenciarProdutos = new System.Windows.Forms.Button();
            this.btnGerenciarClientes = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(77, 247);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(302, 114);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Gestão de Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnGerenciarFornecedores
            // 
            this.btnGerenciarFornecedores.Location = new System.Drawing.Point(77, 69);
            this.btnGerenciarFornecedores.Name = "btnGerenciarFornecedores";
            this.btnGerenciarFornecedores.Size = new System.Drawing.Size(302, 114);
            this.btnGerenciarFornecedores.TabIndex = 5;
            this.btnGerenciarFornecedores.Text = "Gerenciar Fornecedores";
            this.btnGerenciarFornecedores.Click += new System.EventHandler(this.btnGerenciarFornecedores_Click);
            // 
            // btnGerenciarProdutos
            // 
            this.btnGerenciarProdutos.Location = new System.Drawing.Point(473, 69);
            this.btnGerenciarProdutos.Name = "btnGerenciarProdutos";
            this.btnGerenciarProdutos.Size = new System.Drawing.Size(293, 114);
            this.btnGerenciarProdutos.TabIndex = 6;
            this.btnGerenciarProdutos.Text = "Gerenciar Produtos";
            this.btnGerenciarProdutos.Click += new System.EventHandler(this.btnGerenciarProdutos_Click);
            // 
            // btnGerenciarClientes
            // 
            this.btnGerenciarClientes.Location = new System.Drawing.Point(883, 247);
            this.btnGerenciarClientes.Name = "btnGerenciarClientes";
            this.btnGerenciarClientes.Size = new System.Drawing.Size(302, 114);
            this.btnGerenciarClientes.TabIndex = 7;
            this.btnGerenciarClientes.Text = "Gerenciar Clientes";
            this.btnGerenciarClientes.Click += new System.EventHandler(this.btnGerenciarClientes_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(473, 247);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(293, 114);
            this.btnVendas.TabIndex = 8;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(77, 429);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(302, 114);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(883, 69);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(293, 114);
            this.btnCompras.TabIndex = 10;
            this.btnCompras.Text = "Compras";
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(473, 429);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(302, 114);
            this.btnRelatorio.TabIndex = 11;
            this.btnRelatorio.Text = "Relatorios Vendas";
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click_1);
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1256, 615);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnGerenciarFornecedores);
            this.Controls.Add(this.btnGerenciarProdutos);
            this.Controls.Add(this.btnGerenciarClientes);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCompras);
            this.Name = "FormPrincipal";
            this.Text = "+";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnRelatorio;
    }
}
