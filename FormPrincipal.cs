using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                // Oculta ou desabilita o botão de administração para não administradores
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
            FormGestaoVenda formVendas = new FormGestaoVenda();
            formVendas.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FormRelatorioVendas formRelatorios = new FormRelatorioVendas();
            formRelatorios.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Somente administradores podem abrir o FormAdmin
            if (tipoUsuario == "Administrador")
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso restrito a administradores.", "Permissão Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
