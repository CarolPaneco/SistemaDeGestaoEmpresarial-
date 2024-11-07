using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormCompras : Form
    {
        private string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormCompras()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormCompras_Load); // Vincula o evento de carregamento
        }

        private void CarregarFornecedores()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT fornecedor_id, nome FROM Fornecedores";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBoxFornecedores.DataSource = dt;
                comboBoxFornecedores.DisplayMember = "nome";
                comboBoxFornecedores.ValueMember = "fornecedor_id";
            }
        }

        private void CarregarProdutos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Consulta para buscar todos os produtos sem a condição de fornecedor_id
                string query = "SELECT produto_id, nome FROM Produtos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Definindo a origem de dados do comboBox
                comboBoxProduto.DataSource = dt;
                comboBoxProduto.DisplayMember = "nome";  // Nome a ser exibido no comboBox
                comboBoxProduto.ValueMember = "produto_id";  // Valor associado ao item selecionado
            }
        }



        private void FormCompras_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
            ConfigurarDataGridView();
            CarregarProdutos();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewItens.Columns.Clear();  // Limpar as colunas antes de adicionar novas
            dataGridViewItens.Columns.Add("ProdutoId", "Produto ID");
            dataGridViewItens.Columns.Add("Produto", "Produto");
            dataGridViewItens.Columns.Add("Quantidade", "Quantidade");
            dataGridViewItens.Columns.Add("FornecedorId", "Fornecedor ID");
            dataGridViewItens.Columns.Add("Fornecedor", "Fornecedor");
        }



        private void comboBoxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFornecedores.SelectedValue != null)
            {
                int fornecedorId = (int)comboBoxFornecedores.SelectedValue;
                
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            // Obtém o produto, a quantidade e o fornecedor selecionado
            var produto = comboBoxProduto.SelectedItem as DataRowView; // Obtém o DataRowView
            var fornecedor = comboBoxFornecedores.SelectedItem as DataRowView; // Obtém o DataRowView do fornecedor

            if (produto == null || fornecedor == null)
            {
                MessageBox.Show("Selecione um produto e um fornecedor.");
                return;
            }

            // Extrai o nome do produto e fornecedor a partir do DataRowView
            string nomeProduto = produto["nome"].ToString(); // Obtém o nome do produto
            string nomeFornecedor = fornecedor["nome"].ToString(); // Obtém o nome do fornecedor
            int produtoId = (int)produto["produto_id"]; // Obtém o produto_id
            int fornecedorId = (int)fornecedor["fornecedor_id"]; // Obtém o fornecedor_id
            int quantidade = (int)numericUpDownQuantidade.Value; // Obtém a quantidade

            // Adiciona o item ao DataGridView
            dataGridViewItens.Rows.Add(produtoId, nomeProduto, quantidade, fornecedorId, nomeFornecedor);
        }



        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridViewItens.Rows)
                        {
                            if (row.IsNewRow) continue;

                            int produtoId = (int)row.Cells["ProdutoId"].Value;
                            int quantidade = (int)row.Cells["Quantidade"].Value;
                            int fornecedorId = (int)row.Cells["FornecedorId"].Value;

                            RegistrarCompra(produtoId, quantidade, connection, transaction);

                        }

                        transaction.Commit();
                        MessageBox.Show("Compra registrada com sucesso!");
                        dataGridViewItens.Rows.Clear(); // Limpar a lista após registrar
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao registrar compra: " + ex.Message);
                    }
                }
            }
        }

        private void RegistrarCompra(int produtoId, int quantidade, SqlConnection connection, SqlTransaction transaction)

        {
            string insertCompraQuery = "INSERT INTO Compra (produto_id, quantidade) VALUES (@produto_id, @quantidade)";
            using (SqlCommand insertCommand = new SqlCommand(insertCompraQuery, connection, transaction))
            {
                insertCommand.Parameters.AddWithValue("@produto_id", produtoId);
                insertCommand.Parameters.AddWithValue("@quantidade", quantidade);
                insertCommand.ExecuteNonQuery();
            }

            // Atualizar o estoque
            string checkEstoqueQuery = "SELECT COUNT(*) FROM Estoque WHERE produto_id = @produto_id";
            using (SqlCommand checkCommand = new SqlCommand(checkEstoqueQuery, connection, transaction))
            {
                checkCommand.Parameters.AddWithValue("@produto_id", produtoId);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    string updateEstoqueQuery = "UPDATE Estoque SET quantidade = quantidade + @quantidade WHERE produto_id = @produto_id";
                    using (SqlCommand updateCommand = new SqlCommand(updateEstoqueQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@produto_id", produtoId);
                        updateCommand.Parameters.AddWithValue("@quantidade", quantidade);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    string insertEstoqueQuery = "INSERT INTO Estoque (produto_id, quantidade) VALUES (@produto_id, @quantidade)";
                    using (SqlCommand insertEstoqueCommand = new SqlCommand(insertEstoqueQuery, connection, transaction))
                    {
                        insertEstoqueCommand.Parameters.AddWithValue("@produto_id", produtoId);
                        insertEstoqueCommand.Parameters.AddWithValue("@quantidade", quantidade);
                        insertEstoqueCommand.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
