using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormAdicionarUsuario : Form
    {
        private const string ConnectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormAdicionarUsuario()
        {
            InitializeComponent();

            // Certifique-se de que 'cmbTipoUsuario' é um ComboBox no Designer.
            // Preenche o ComboBox com as opções "Administrador" e "Usuário"
            cmbTipoUsuario.Items.Add("Administrador");
            cmbTipoUsuario.Items.Add("Usuário");

            // Define a opção padrão
            cmbTipoUsuario.SelectedIndex = 0; // Define "Administrador" como padrão
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário e a senha foram preenchidos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string tipoUsuario = cmbTipoUsuario.SelectedItem.ToString(); // Obtém o valor selecionado

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Usuarios (Usuario, Senha, TipoUsuario) VALUES (@usuario, @senha, @tipoUsuario)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário adicionado com sucesso.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException ex) // Captura exceções específicas do SQL Server
                {
                    MessageBox.Show("Erro ao adicionar usuário: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário sem salvar
        }
    }
}
