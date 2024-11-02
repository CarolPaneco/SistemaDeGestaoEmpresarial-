namespace SistemaFazenda2
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGerenciarFornecedores;
        private System.Windows.Forms.Button btnGerenciarProdutos;
        private System.Windows.Forms.Button btnGerenciarClientes;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnAdmin;

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
            this.btnGerenciarFornecedores = new System.Windows.Forms.Button();
            this.btnGerenciarProdutos = new System.Windows.Forms.Button();
            this.btnGerenciarClientes = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();

            // FormPrincipal
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnGerenciarFornecedores);
            this.Controls.Add(this.btnGerenciarProdutos);
            this.Controls.Add(this.btnGerenciarClientes);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnAdmin);
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Button Gerenciar Fornecedores
            this.btnGerenciarFornecedores.Text = "Gerenciar Fornecedores";
            this.btnGerenciarFornecedores.Location = new System.Drawing.Point(50, 50);
            this.btnGerenciarFornecedores.Size = new System.Drawing.Size(200, 50);
            this.btnGerenciarFornecedores.Click += new System.EventHandler(this.btnGerenciarFornecedores_Click);

            // Button Gerenciar Produtos
            this.btnGerenciarProdutos.Text = "Gerenciar Produtos";
            this.btnGerenciarProdutos.Location = new System.Drawing.Point(50, 120);
            this.btnGerenciarProdutos.Size = new System.Drawing.Size(200, 50);
            this.btnGerenciarProdutos.Click += new System.EventHandler(this.btnGerenciarProdutos_Click);

            // Button Gerenciar Clientes
            this.btnGerenciarClientes.Text = "Gerenciar Clientes";
            this.btnGerenciarClientes.Location = new System.Drawing.Point(50, 190);
            this.btnGerenciarClientes.Size = new System.Drawing.Size(200, 50);
            this.btnGerenciarClientes.Click += new System.EventHandler(this.btnGerenciarClientes_Click);

            // Button Vendas
            this.btnVendas.Text = "Vendas";
            this.btnVendas.Location = new System.Drawing.Point(50, 260);
            this.btnVendas.Size = new System.Drawing.Size(200, 50);
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);

            // Button Relatórios
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.Location = new System.Drawing.Point(50, 330);
            this.btnRelatorios.Size = new System.Drawing.Size(200, 50);
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);

            // Button Admin
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Location = new System.Drawing.Point(50, 400);
            this.btnAdmin.Size = new System.Drawing.Size(200, 50);
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
        }
    }
}
