using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormGestaoProdutos : Form
    {
        private const string ConnectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";
        private int produtoId;  // Armazenará o Produto_id
        public FormGestaoProdutos()
        {
            InitializeComponent();
            CarregarProdutos(); // Chama o método para carregar os produtos ao iniciar o formulário
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormAdicionarProduto formAdicionar = new FormAdicionarProduto();
            formAdicionar.FormClosed += (s, args) => CarregarProdutos();
            formAdicionar.Show();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                // Obtém o produto selecionado
                var produtoSelecionado = (Produto)dataGridViewProdutos.SelectedRows[0].DataBoundItem;

                // Passa o Produto_id para o FormEditarProduto
                FormEditarProduto formEditar = new FormEditarProduto(produtoSelecionado.produto_id);  // Passando apenas o Produto_id

                formEditar.FormClosed += (s, args) => CarregarProdutos(); // Recarregar os produtos após fechar o formulário
                formEditar.Show();
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }
        }


        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                var produtoSelecionado = (Produto)dataGridViewProdutos.SelectedRows[0].DataBoundItem;

                // Confirmação antes de excluir
                var result = MessageBox.Show($"Tem certeza que deseja excluir o produto '{produtoSelecionado.nome}'?",
                                              "Confirmação",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ExcluirProduto(produtoSelecionado.produto_id);
                    CarregarProdutos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.");
            }
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

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Produtos WHERE nome LIKE @Pesquisa";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Pesquisa", "%" + pesquisa + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produto produto = new Produto
                            {
                                produto_id = (int)reader["produto_id"],
                                nome = reader["nome"].ToString(),
                                descricao = reader["descricao"] != DBNull.Value ? reader["descricao"].ToString() : string.Empty,
                                preco = (decimal)reader["preco"],
                                quantidade_em_estoque = reader["quantidade_em_estoque"] != DBNull.Value ? (int)reader["quantidade_em_estoque"] : 0,
                                
                               
                            };
                            produtos.Add(produto);
                        }
                    }
                }
            }
            return produtos; // Retorna a lista de produtos encontrados
        }

        private void CarregarProdutos()
        {
            List<Produto> produtos = BuscarProdutos(""); // Chama com string vazia para carregar todos
            dataGridViewProdutos.DataSource = produtos; // Preenche a DataGridView com todos os produtos

            // Ocultar as colunas indesejadas
            dataGridViewProdutos.Columns["quantidade_em_estoque"].Visible = false;
            dataGridViewProdutos.Columns["preco_unitario"].Visible = false;
        }


        private void ExcluirProduto(int produtoId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Excluir os registros relacionados na tabela Vendas
                string deleteVendasQuery = "DELETE FROM Vendas WHERE produto_id = @ProdutoId";
                using (SqlCommand command = new SqlCommand(deleteVendasQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);
                    command.ExecuteNonQuery();
                }

                // Excluir os registros relacionados na tabela Estoque
                string deleteEstoqueQuery = "DELETE FROM Estoque WHERE produto_id = @ProdutoId";
                using (SqlCommand command = new SqlCommand(deleteEstoqueQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);
                    command.ExecuteNonQuery();
                }

                // Agora exclua o produto da tabela Produtos
                string deleteProdutoQuery = "DELETE FROM Produtos WHERE produto_id = @ProdutoId";
                using (SqlCommand command = new SqlCommand(deleteProdutoQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);
                    command.ExecuteNonQuery();
                }
            }
        }




    }
}
