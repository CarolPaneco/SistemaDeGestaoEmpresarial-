using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormEstoque : Form
    {
        private string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormEstoque()
        {
            InitializeComponent();
            CarregarEstoque();
        }

        // Método para carregar os dados de estoque no DataGridView
        public void CarregarEstoque()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT e.produto_id AS id_produto, p.nome AS nome, e.quantidade AS quantidade " +
                               "FROM Estoque e " +
                               "JOIN Produtos p ON e.produto_id = p.produto_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open(); // Assegura que a conexão está aberta
                    adapter.Fill(dt); // Preenche o DataTable

                    // Limpa o DataGridView antes de atribuir um novo DataSource
                    dataGridViewEstoque.DataSource = null;
                    dataGridViewEstoque.DataSource = dt; // Atualiza o DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar estoque: " + ex.Message);
                }
            }
        }


        // Evento do botão btnAtualizar para recarregar os dados no DataGridView
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarEstoque(); // Atualiza os dados de estoque
        }

        public void AtualizarEstoque()
        {
            CarregarEstoque(); // Chama o método que já carrega os dados
        }

    }
}
