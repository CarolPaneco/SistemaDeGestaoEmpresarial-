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
            string connectionString = "sua_string_de_conexao_aqui"; // Altere para a string de conexão do seu banco de dados

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Produtos (Nome, Preco) VALUES (@Nome, @Preco)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", txtNome.Text);
                    command.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
