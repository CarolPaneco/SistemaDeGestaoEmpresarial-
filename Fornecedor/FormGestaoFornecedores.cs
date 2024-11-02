using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormGestaoFornecedores : Form
    {
        public FormGestaoFornecedores()
        {
            InitializeComponent();
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {   


            List<Fornecedor> fornecedores = new List<Fornecedor>();
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;"; // Altere para a string de conexão do seu banco de dados

            using (SqlConnection connection = new SqlConnection(connectionString))

            {

                connection.Open();
                string query = "SELECT * FROM Fornecedores";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fornecedor fornecedor = new Fornecedor
                            {
                                fornecedor_id = (int)reader["fornecedor_id"], // Ajustando o nome da coluna
                                nome = reader["nome"].ToString(), // Ajustando o nome da coluna
                                cnpj_Cpf = reader["cnpj_cpf"].ToString(), // Ajustando o nome da coluna
                                endereco = reader["endereco"].ToString(), // Ajustando o nome da coluna
                                telefone = reader["telefone"].ToString(), // Ajustando o nome da coluna
                                email = reader["email"].ToString(), // Ajustando o nome da coluna
                                data_cadastro = reader["data_cadastro"] != DBNull.Value
                                    ? (DateTime)reader["data_cadastro"]
                                    : DateTime.MinValue // ou outra data padrão
                            };
                            fornecedores.Add(fornecedor);
                        }
                    }
                }
            }

            dataGridViewFornecedores.DataSource = fornecedores;
        }

        private bool IsFormOpen<T>() where T : Form
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is T)
                {
                    return true; // O formulário já está aberto
                }
            }
            return false; // O formulário não está aberto
        }


        

        

        // Método para buscar o fornecedor no banco de dados
        private Fornecedor BuscarFornecedorPorId(int id)
        {
            Fornecedor fornecedor = null;
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;"; // Altere para a string de conexão do seu banco de dados

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Fornecedores WHERE fornecedor_id = @Id"; // Ajustando o nome da coluna

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fornecedor = new Fornecedor
                            {
                                fornecedor_id = (int)reader["fornecedor_id"], // Ajustando o nome da coluna
                                nome = reader["nome"].ToString(), // Ajustando o nome da coluna
                                cnpj_Cpf = reader["cnpj_cpf"].ToString(), // Ajustando o nome da coluna
                                endereco = reader["endereco"].ToString(), // Ajustando o nome da coluna
                                telefone = reader["telefone"].ToString(), // Ajustando o nome da coluna
                                email = reader["email"].ToString() // Ajustando o nome da coluna
                            };
                        }
                    }
                }
            }
            return fornecedor; // Retorna o fornecedor encontrado
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            // Crie uma nova instância do formulário de adicionar fornecedor
            FormAdicionarFornecedor adicionarFornecedor = new FormAdicionarFornecedor();
            adicionarFornecedor.Show(); // Abre o formulário de adicionar fornecedor
        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewFornecedores.SelectedRows.Count > 0)
            {
                // Obtém o ID do fornecedor selecionado
                int idFornecedor = (int)dataGridViewFornecedores.SelectedRows[0].Cells["fornecedor_id"].Value; // Ajustando o nome da coluna

                // Aqui você deve buscar o fornecedor no banco de dados
                Fornecedor fornecedor = BuscarFornecedorPorId(idFornecedor);

                // Agora você pode passar o objeto Fornecedor para o FormEditarFornecedor
                FormEditarFornecedor formEditar = new FormEditarFornecedor(fornecedor);
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    CarregarFornecedores(); // Recarrega a lista de fornecedores
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para editar.");
            }
        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewFornecedores.SelectedRows.Count > 0)
            {
                int idFornecedor = (int)dataGridViewFornecedores.SelectedRows[0].Cells["fornecedor_id"].Value;

                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja remover este fornecedor?", "Remover Fornecedor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Fornecedores WHERE fornecedor_id = @Id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", idFornecedor);
                            command.ExecuteNonQuery();
                        }
                    }

                    CarregarFornecedores(); // Recarrega a lista de fornecedores
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para remover.");
            }
        }
    }
}
