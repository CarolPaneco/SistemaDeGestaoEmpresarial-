using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormAdicionarVenda : Form
    {
        private const string ConnectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormAdicionarVenda()
        {
            InitializeComponent();
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
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Vendas (produto_id, quantidade, preco_total, cliente_id) VALUES (@produtoId, @quantidade, @precoTotal, @clienteId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@produtoId", int.Parse(txtProdutoId.Text));
                        command.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                        command.Parameters.AddWithValue("@precoTotal", decimal.Parse(txtPrecoTotal.Text));
                        command.Parameters.AddWithValue("@clienteId", int.Parse(txtClienteId.Text));

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Venda adicionada com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar venda: " + ex.Message);
            }
        }
    }
}
