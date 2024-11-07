using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormAdicionarProduto : Form
    {
        public FormAdicionarProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AdicionarProduto();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AdicionarProduto()
        {
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;"; // Altere para a string de conexão do seu banco de dados

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Produtos (Nome, Preco, quantidade_em_estoque, descricao) VALUES (@Nome, @Preco, @Quantidade, @Descricao)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", txtNome.Text); // Nome do produto
                    command.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text)); // Preço do produto
                    command.Parameters.AddWithValue("@Quantidade", 0); // Valor inicial para quantidade_em_estoque (pode ser 0)
                    command.Parameters.AddWithValue("@Descricao", txtDescricao.Text); // Descrição do produto (adicionado)

                    command.ExecuteNonQuery(); // Executa o comando no banco de dados
                }
            }
        }


    }
}
