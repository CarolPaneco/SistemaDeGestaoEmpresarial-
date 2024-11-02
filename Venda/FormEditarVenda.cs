using System;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormEditarVenda : Form
    {
        private Venda vendaAtual;

        public FormEditarVenda()
        {
            InitializeComponent();
        }

        // Novo construtor que aceita um objeto Venda
        public FormEditarVenda(Venda vendaSelecionada) : this()
        {
            vendaAtual = vendaSelecionada;

            // Preenche os campos de texto com os dados da venda
            txtProdutoId.Text = vendaAtual.produto_id.ToString();
            txtQuantidade.Text = vendaAtual.quantidade.ToString();
            txtPrecoTotal.Text = vendaAtual.preco_total.ToString("F2");
            txtClienteId.Text = vendaAtual.cliente_id.ToString();

            // Define a cor dos textos para preto
            txtProdutoId.ForeColor = System.Drawing.Color.Black;
            txtQuantidade.ForeColor = System.Drawing.Color.Black;
            txtPrecoTotal.ForeColor = System.Drawing.Color.Black;
            txtClienteId.ForeColor = System.Drawing.Color.Black;
        }

        private void txtProdutoId_Enter(object sender, EventArgs e)
        {
            if (txtProdutoId.Text == "ID do Produto")
            {
                txtProdutoId.Text = "";
                txtProdutoId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtProdutoId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProdutoId.Text))
            {
                txtProdutoId.Text = "ID do Produto";
                txtProdutoId.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "Quantidade")
            {
                txtQuantidade.Text = "";
                txtQuantidade.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                txtQuantidade.Text = "Quantidade";
                txtQuantidade.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPrecoTotal_Enter(object sender, EventArgs e)
        {
            if (txtPrecoTotal.Text == "Preço Total")
            {
                txtPrecoTotal.Text = "";
                txtPrecoTotal.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPrecoTotal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecoTotal.Text))
            {
                txtPrecoTotal.Text = "Preço Total";
                txtPrecoTotal.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtClienteId_Enter(object sender, EventArgs e)
        {
            if (txtClienteId.Text == "ID do Cliente")
            {
                txtClienteId.Text = "";
                txtClienteId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtClienteId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClienteId.Text))
            {
                txtClienteId.Text = "ID do Cliente";
                txtClienteId.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Aqui, atualize a venda com os dados editados e salve no banco de dados ou na lista de vendas
            if (vendaAtual != null)
            {
                // Exemplo de atualização dos dados da venda
                vendaAtual.produto_id = int.Parse(txtProdutoId.Text);
                vendaAtual.quantidade = int.Parse(txtQuantidade.Text);
                vendaAtual.preco_total = decimal.Parse(txtPrecoTotal.Text);
                vendaAtual.cliente_id = int.Parse(txtClienteId.Text);


                // Código para salvar as mudanças na venda (ex.: atualizar no banco de dados)
                MessageBox.Show("Venda atualizada com sucesso.");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a venda.");
            }

            this.Close(); // Fecha o formulário após salvar
        }
    }
}
