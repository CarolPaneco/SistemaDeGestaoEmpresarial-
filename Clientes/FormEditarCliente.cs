using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormEditarCliente : Form
    {
        private Cliente cliente;

        public FormEditarCliente(Cliente clienteSelecionado)
        {
            InitializeComponent();
            cliente = clienteSelecionado;

            // Inicialize os campos de texto com os dados do cliente selecionado
            txtNome.Text = cliente.Nome;
            txtCpfCnpj.Text = cliente.cpf_cnpj;
            txtEndereco.Text = cliente.Endereco;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Salva os dados editados no banco de dados
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;"; // Substitua pela sua string de conexão
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Clientes SET Nome = @nome, cpf_cnpj = @cpf_cnpj, Endereco = @endereco, Telefone = @telefone, Email = @email WHERE cliente_id = @cliente_id";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@nome", txtNome.Text);
                    command.Parameters.AddWithValue("@cpf_cnpj", txtCpfCnpj.Text);
                    command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    command.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@cliente_id", cliente.cliente_id); // Aqui estamos usando o ID do cliente

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente atualizado com sucesso!");
                        this.Close(); // Fecha o formulário após salvar
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o cliente.");
                    }
                }
            }
        }
    }
}
