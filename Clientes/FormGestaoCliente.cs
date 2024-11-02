using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormGestaoCliente : Form
    {
        private const string ConnectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormGestaoCliente()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = ObterClientes();
            dataGridViewClientes.DataSource = clientes;
        }

        private List<Cliente> ObterClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Clientes";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            cliente_id = (int)reader["cliente_id"],
                            Nome = reader["nome"].ToString(),
                            cpf_cnpj = reader["cpf_cnpj"].ToString(),
                            Endereco = reader["endereco"].ToString(),
                            Telefone = reader["telefone"].ToString(),
                            Email = reader["email"].ToString(),
                            DataCadastro = (DateTime)reader["data_cadastro"]
                        };
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            FormAdicionarCliente formAdicionar = new FormAdicionarCliente();
            formAdicionar.FormClosed += (s, args) => CarregarClientes();
            formAdicionar.Show();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                var clienteSelecionado = (Cliente)dataGridViewClientes.SelectedRows[0].DataBoundItem;
                FormEditarCliente formEditar = new FormEditarCliente(clienteSelecionado);
                formEditar.FormClosed += (s, args) => CarregarClientes();
                formEditar.Show();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                var clienteSelecionado = (Cliente)dataGridViewClientes.SelectedRows[0].DataBoundItem;
                ExcluirCliente(clienteSelecionado.cliente_id);
                CarregarClientes();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.");
            }
        }

        private void ExcluirCliente(int clienteId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Clientes WHERE cliente_id = @ClienteId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClienteId", clienteId);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void CarregarClientes(string filtro = "")
        {
            // Supondo que você tenha uma lista de clientes que vem do banco de dados ou serviço.
            List<Cliente> clientes = ObterClientesDoBanco(filtro);
            dataGridViewClientes.DataSource = clientes;
        }

        // Método que busca clientes no banco de dados com base no filtro
        private List<Cliente> ObterClientesDoBanco(string filtro)
        {
            List<Cliente> clientes = new List<Cliente>();
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;"; // Defina sua string de conexão

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Clientes";

                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE Nome LIKE @filtro OR cpf_cnpj LIKE @filtro";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        command.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                cliente_id = (int)reader["cliente_id"],
                                Nome = reader["Nome"].ToString(),
                                cpf_cnpj = reader["cpf_cnpj"].ToString(),
                                Endereco = reader["Endereco"].ToString(),
                                Telefone = reader["Telefone"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            clientes.Add(cliente);
                        }
                    }
                }
            }
            return clientes;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // Obter o texto de busca da caixa de texto
            string termoBusca = txtBuscarCliente.Text.Trim();
            // Chamar o método CarregarClientes com o termo de busca
            CarregarClientes(termoBusca);
        }



    }
}
