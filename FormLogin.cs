using SistemaFazenda2;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormLogin : Form
    {
        

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Verifica se o usuário e senha estão corretos
                string query = "SELECT TipoUsuario FROM Usuarios WHERE Usuario = @usuario AND Senha = @senha";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@senha", senha);

                string tipoUsuario = command.ExecuteScalar()?.ToString();

                if (!string.IsNullOrEmpty(tipoUsuario))
                {
                    // Login bem-sucedido, abra o FormPrincipal com o tipo de usuário
                    FormPrincipal formPrincipal = new FormPrincipal(usuario, tipoUsuario);
                    formPrincipal.Show();
                    this.Hide(); // Oculta o formulário de login
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
        }

    }
}
