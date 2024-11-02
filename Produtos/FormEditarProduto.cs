using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormEditarProduto : Form
    {
        private int produtoId;

        public FormEditarProduto(int id)
        {
            InitializeComponent();
            produtoId = id;
            CarregarProduto();
        }

        private void CarregarProduto()
        {
            Produto produto = BuscarProdutoPorId(produtoId);
            if (produto != null)
            {
                txtNome.Text = produto.nome;
                txtPreco.Text = produto.preco.ToString("F2");
                txtQuantidade.Text = produto.quantidade.ToString();
                txtDescricao.Text = produto.descricao;
            }
            else
            {
                MessageBox.Show("Produto não encontrado.");
                this.Close();
            }
        }

        private Produto BuscarProdutoPorId(int id)
        {
            Produto produto = null;
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Produtos WHERE produto_id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            produto = new Produto
                            {
                                produto_id = (int)reader["produto_id"],
                                nome = reader["nome"].ToString(),
                                preco = (decimal)reader["preco"],
                                quantidade = (int)reader["quantidade"],
                                descricao = reader["descricao"].ToString()
                            };
                        }
                    }
                }
            }
            return produto;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal preco = decimal.Parse(txtPreco.Text);
            int quantidade = int.Parse(txtQuantidade.Text);
            string descricao = txtDescricao.Text;

            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Produtos SET nome = @Nome, preco = @Preco, quantidade = @Quantidade, descricao = @Descricao WHERE produto_id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Preco", preco);
                        command.Parameters.AddWithValue("@Quantidade", quantidade);
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        command.Parameters.AddWithValue("@Id", produtoId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto atualizado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
        }
    }
}
