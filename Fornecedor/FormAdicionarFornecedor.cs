using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormAdicionarFornecedor : Form
    {
        public FormAdicionarFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cnpjCpf = txtCnpjCpf.Text;
            string endereco = txtEndereco.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;

            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Fornecedores (nome, cnpj_cpf, endereco, telefone, email) VALUES (@Nome, @CnpjCpf, @Endereco, @Telefone, @Email)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@CnpjCpf", cnpjCpf);
                        command.Parameters.AddWithValue("@Endereco", endereco);
                        command.Parameters.AddWithValue("@Telefone", telefone);
                        command.Parameters.AddWithValue("@Email", email);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Fornecedor adicionado com sucesso!");
                this.DialogResult = DialogResult.OK; // Retorna OK
                this.Close(); // Fecha o formulário
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar fornecedor: " + ex.Message);
            }
        }
    }
}
