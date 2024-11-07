using System;
using SistemaFazenda2;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaVenda;

namespace SistemaFazenda2
{
    public partial class FormPrincipal : Form

    {

        private string usuarioAtual;
        private string tipoUsuario;

        public FormPrincipal(string usuarioAtual, string tipoUsuario)
        {
            InitializeComponent();
            this.usuarioAtual = usuarioAtual;
            this.tipoUsuario = tipoUsuario;

            VerificarPermissao();
        }

        private void VerificarPermissao()
        {
            if (tipoUsuario != "Administrador")
            {

                btnAdmin.Enabled = false;

            }
        }

        private void btnGerenciarFornecedores_Click(object sender, EventArgs e)
        {

            FormGestaoFornecedores formFornecedores = new FormGestaoFornecedores();
            formFornecedores.ShowDialog();
        }

        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
            FormGestaoProdutos formProdutos = new FormGestaoProdutos();
            formProdutos.ShowDialog();
        }

        private void btnGerenciarClientes_Click(object sender, EventArgs e)
        {
            FormGestaoCliente formClientes = new FormGestaoCliente();
            formClientes.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormSelecionarCliente formVendas = new FormSelecionarCliente();
            formVendas.ShowDialog();
        }



        private void btnAdmin_Click(object sender, EventArgs e)
        {


            FormAdmin formAdmin = new FormAdmin();
            formAdmin.ShowDialog();

        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FormEstoque formEstoque = new FormEstoque();
            formEstoque.ShowDialog(); // Abre o formulário de estoque
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FormCompras formCompras = new FormCompras();
            formCompras.ShowDialog(); // Abre o formulário de estoque
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FormCompras formCompras = new FormCompras();
            formCompras.ShowDialog(); // Abre o formulário de estoque
        }

        private void btnRelatorio_Click_1(object sender, EventArgs e)
        {
            FormRelatorioVendas formRelatorioVendas = new FormRelatorioVendas();
            formRelatorioVendas.ShowDialog(); // Abre o formulário de estoque
        }
    }
}
