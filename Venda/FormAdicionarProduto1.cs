using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaFazenda2;

namespace SistemaFazenda2
{
    public partial class FormAdicionarProduto1 : Form
    {
        private int clienteId;
        public int ClienteId { get; set; }

        public FormAdicionarProduto1(int clienteId)
        {
            InitializeComponent();
            this.clienteId = clienteId;
            this.ClienteId = clienteId;  // Atribuindo o ClienteId ao campo e propriedade
        }

        private void FormAdicionarProduto1_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            ConfigurarDataGridView();
        }

        private void CarregarProdutos()
        {
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";
            string query = "SELECT produto_id, nome, preco FROM Produtos";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        listBoxProdutos.DataSource = dataTable;
                        listBoxProdutos.DisplayMember = "nome";
                        listBoxProdutos.ValueMember = "produto_id";
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado no banco de dados.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewItens.Columns.Add("ProdutoId", "ID do Produto");
            dataGridViewItens.Columns.Add("ProdutoNome", "Produto");
            dataGridViewItens.Columns.Add("Quantidade", "Quantidade");
            dataGridViewItens.Columns.Add("PrecoUnitario", "Preço Unitário");
            dataGridViewItens.Columns.Add("PrecoTotal", "Preço Total");
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (listBoxProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            int produtoId = (int)((DataRowView)listBoxProdutos.SelectedItem)["produto_id"];
            string produtoNome = ((DataRowView)listBoxProdutos.SelectedItem)["nome"].ToString();
            decimal precoUnitario = (decimal)((DataRowView)listBoxProdutos.SelectedItem)["preco"];
            int quantidade = (int)numericUpDownQuantidade.Value;

            if (!VerificarEstoque(produtoId, quantidade))
            {
                MessageBox.Show("Quantidade em estoque insuficiente.");
                return;
            }

            decimal precoTotal = precoUnitario * quantidade;

            dataGridViewItens.Rows.Add(produtoId, produtoNome, quantidade, precoUnitario, precoTotal);
        }

        private bool VerificarEstoque(int produtoId, int quantidade)
        {
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";
            string query = "SELECT quantidade FROM Estoque WHERE produto_id = @produtoId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@produtoId", produtoId);
                connection.Open();

                int quantidadeEmEstoque = (int)command.ExecuteScalar();
                return quantidadeEmEstoque >= quantidade;
            }
        }

        private void btnRealizarVenda_Click(object sender, EventArgs e)
        {
            int clienteId = this.ClienteId;  // Supondo que o ID do cliente foi definido ao abrir o formulário
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insere a venda e obtém o venda_id gerado
                    string insertVendaQuery = "INSERT INTO Vendas (cliente_id, data_venda) OUTPUT INSERTED.venda_id VALUES (@ClienteId, GETDATE())";
                    int vendaId;

                    using (SqlCommand command = new SqlCommand(insertVendaQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ClienteId", clienteId);
                        vendaId = (int)command.ExecuteScalar();  // Obter o ID da venda
                    }

                    // Insere cada item na tabela ItensVenda
                    string insertItemQuery = "INSERT INTO ItensVenda (venda_id, produto_id, quantidade, preco_unitario) VALUES (@VendaId, @ProdutoId, @Quantidade, @PrecoUnitario)";
                    foreach (DataGridViewRow row in dataGridViewItens.Rows)
                    {
                        if (row.Cells["ProdutoId"].Value == null) continue;  // Evita erro ao percorrer células vazias

                        int produtoId = Convert.ToInt32(row.Cells["ProdutoId"].Value);
                        int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                        decimal precoUnitario = Convert.ToDecimal(row.Cells["PrecoUnitario"].Value);

                        using (SqlCommand command = new SqlCommand(insertItemQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@VendaId", vendaId);
                            command.Parameters.AddWithValue("@ProdutoId", produtoId);
                            command.Parameters.AddWithValue("@Quantidade", quantidade);
                            command.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
                            command.ExecuteNonQuery();
                        }

                        // Atualiza o estoque
                        AtualizarEstoque(produtoId, quantidade, connection, transaction);
                    }

                    transaction.Commit();
                    MessageBox.Show("Venda realizada com sucesso!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao realizar a venda: " + ex.Message);
                }
            }

            this.Close();
        }

        private void AtualizarEstoque(int produtoId, int quantidade, SqlConnection connection, SqlTransaction transaction)
        {
            string query = "UPDATE Estoque SET quantidade = quantidade - @quantidade WHERE produto_id = @produtoId";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.AddWithValue("@produtoId", produtoId);
                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.ExecuteNonQuery();
            }
        }
    }
}
