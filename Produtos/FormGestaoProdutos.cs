using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormGestaoProdutos : Form
    {
        public FormGestaoProdutos()
        {
            InitializeComponent();
            CarregarProdutos(); // Chama o método para carregar os produtos ao iniciar o formulário
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar produto
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            // Lógica para editar produto
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            // Lógica para excluir produto
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisaProduto.Text.Trim();
            List<Produto> produtos = BuscarProdutos(pesquisa);
            dataGridViewProdutos.DataSource = produtos; // Preenche a DataGridView com os resultados
        }

        private List<Produto> BuscarProdutos(string pesquisa)
        {
            List<Produto> produtos = new List<Produto>();
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Produtos WHERE nome LIKE @Pesquisa"; // Ajuste conforme necessário

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Pesquisa", "%" + pesquisa + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Produto produto = new Produto
                                {
                                    produto_id = (int)reader["produto_id"], // Verifique o nome da coluna
                                    nome = reader["nome"].ToString(),
                                    preco = reader.IsDBNull(reader.GetOrdinal("preco")) ? 0 : (decimal)reader["preco"], // Verificação de DBNull
                                    quantidade = reader.IsDBNull(reader.GetOrdinal("quantidade_em_estoque")) ? 0 : (int)reader["quantidade_em_estoque"], // Ajuste para o nome correto
                                    descricao = reader["descricao"].ToString() // Verifique o nome da coluna
                                };

                                produtos.Add(produto);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao buscar produtos: {ex.Message}");
            }
            return produtos; // Retorna a lista de produtos encontrados
        }

        private void CarregarProdutos()
        {
            List<Produto> produtos = BuscarProdutos(""); // Chama com string vazia para carregar todos
            dataGridViewProdutos.DataSource = produtos;
        }
    }
}
