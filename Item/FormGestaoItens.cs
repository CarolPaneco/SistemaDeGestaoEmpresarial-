using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormGestaoItens : Form
    {
        public FormGestaoItens()
        {
            InitializeComponent();
            CarregarItens();
        }

        private void CarregarItens()
        {
            string connectionString = "sua_string_de_conexao_aqui"; // Altere para a string de conexão do seu banco de dados

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Itens";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewItens.DataSource = dataTable;
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            FormAdicionarItem formAdicionar = new FormAdicionarItem();
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                CarregarItens();
            }
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItens.CurrentRow != null)
            {
                int itemId = (int)dataGridViewItens.CurrentRow.Cells["Id"].Value;
                string nome = dataGridViewItens.CurrentRow.Cells["Nome"].Value.ToString();
                int quantidade = Convert.ToInt32(dataGridViewItens.CurrentRow.Cells["Quantidade"].Value);
                decimal preco = Convert.ToDecimal(dataGridViewItens.CurrentRow.Cells["Preco"].Value);

                Item itemSelecionado = new Item
                {
                    Id = itemId,
                    Nome = nome,
                    Quantidade = quantidade,
                    Preco = preco
                };

                FormEditarItem formEditar = new FormEditarItem(itemSelecionado);
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    CarregarItens();
                }
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewItens.CurrentRow != null)
            {
                int itemId = (int)dataGridViewItens.CurrentRow.Cells["Id"].Value;

                string connectionString = "sua_string_de_conexao_aqui"; // Altere para a string de conexão do seu banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Itens WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", itemId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                CarregarItens();
            }
        }
    }
}
