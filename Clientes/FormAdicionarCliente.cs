using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormAdicionarCliente : Form
    {
        public FormAdicionarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // String de conexão ao banco de dados (substitua pela sua)
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Clientes (Nome, cpf_cnpj, Endereco, Telefone, Email) " +
                                     "VALUES (@nome, @cpf_cnpj, @endereco, @telefone, @email)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@nome", txtNome.Text);
                    command.Parameters.AddWithValue("@cpf_cnpj", txtCpfCnpj.Text);
                    command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    command.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente adicionado com sucesso!");
                            this.Close(); // Fecha o formulário após adicionar o cliente
                        }
                        else
                        {
                            MessageBox.Show("Erro ao adicionar o cliente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro: {ex.Message}");
                    }
                }
            }
        }
    }
}
