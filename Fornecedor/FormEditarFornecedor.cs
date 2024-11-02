using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormEditarFornecedor : Form
    {
        private Fornecedor fornecedor;

        public FormEditarFornecedor(Fornecedor fornecedor)
        {
            InitializeComponent();
            this.fornecedor = fornecedor;
            CarregarDados();
        }

        private void CarregarDados()
        {
            txtNome.Text = fornecedor.nome;
            txtCnpjCpf.Text = fornecedor.cnpj_Cpf;
            txtEndereco.Text = fornecedor.endereco;
            txtTelefone.Text = fornecedor.telefone;
            txtEmail.Text = fornecedor.email;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Fornecedores SET nome = @Nome, cnpj_cpf = @CnpjCpf, endereco = @Endereco, telefone = @Telefone, email = @Email WHERE fornecedor_id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", fornecedor.fornecedor_id);
                    command.Parameters.AddWithValue("@Nome", txtNome.Text);
                    command.Parameters.AddWithValue("@CnpjCpf", txtCnpjCpf.Text);
                    command.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                    command.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    command.ExecuteNonQuery();
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
