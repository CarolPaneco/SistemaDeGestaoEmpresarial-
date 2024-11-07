using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormEditarProduto : Form
    {
        private int produtoId;

        public FormEditarProduto(int produtoId)
        {
            InitializeComponent();
            this.produtoId = produtoId;
            CarregarDadosProduto();
        }

        private void CarregarDadosProduto()
        {
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nome, descricao, preco FROM Produtos WHERE produto_id = @ProdutoId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNome.Text = reader["nome"].ToString();
                            txtDescricao.Text = reader["descricao"].ToString();
                            txtPreco.Text = reader["preco"].ToString();
                            
                            
                        }
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Produtos SET nome = @Nome, descricao = @Descricao, preco = @Preco WHERE produto_id = @ProdutoId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProdutoId", produtoId);
                    command.Parameters.AddWithValue("@Nome", txtNome.Text);
                    command.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                    command.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));
                    

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Produto atualizado com sucesso!");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
