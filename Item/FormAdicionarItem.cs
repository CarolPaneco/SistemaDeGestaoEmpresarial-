using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormAdicionarItem : Form
    {
        public FormAdicionarItem()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Adiciona um novo item ao banco de dados
            AdicionarItem();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AdicionarItem()
        {
            string connectionString = "sua_string_de_conexao_aqui"; // Altere para a string de conexão do seu banco de dados

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Itens (Nome, Quantidade, Preco) VALUES (@Nome, @Quantidade, @Preco)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", txtNome.Text);
                    command.Parameters.AddWithValue("@Quantidade", int.Parse(txtQuantidade.Text));
                    command.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
