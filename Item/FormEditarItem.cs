using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormEditarItem : Form
    {
        private int itemId;

        public FormEditarItem(Item item)
        {
            InitializeComponent();

            // Armazena o ID do item para atualizações
            itemId = item.Id;

            // Preenche os campos com os dados do item
            txtNome.Text = item.Nome;
            txtQuantidade.Text = item.Quantidade.ToString();
            txtPreco.Text = item.Preco.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Atualiza os dados do item no banco de dados
            AtualizarItem();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AtualizarItem()
        {
            string connectionString = "sua_string_de_conexao_aqui"; // Altere para a string de conexão do seu banco de dados

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Itens SET Nome = @Nome, Quantidade = @Quantidade, Preco = @Preco WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", itemId);
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
