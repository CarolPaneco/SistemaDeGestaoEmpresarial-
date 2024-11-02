using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormEditarUsuario : Form
    {
        private int usuarioId;
        private string usuarioAtual;
        private const string ConnectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormEditarUsuario(int id, string usuario, string senha, string tipoUsuario)
        {
            InitializeComponent();
            usuarioId = id;
            usuarioAtual = usuario; // Definindo o valor de usuarioAtual
            txtUsuario.Text = usuario;
            txtSenha.Text = senha;
            cmbTipoUsuario.SelectedItem = tipoUsuario;
        }

        private void VerificarPermissao()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT TipoUsuario FROM Usuarios WHERE Usuario = @usuarioAtual";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioAtual", usuarioAtual);

                string tipoUsuario = command.ExecuteScalar()?.ToString();

                if (tipoUsuario != "Administrador")
                {
                    MessageBox.Show("Apenas usuários administrativos podem editar usuários.", "Permissão Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificarPermissao();

            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string tipoUsuario = cmbTipoUsuario.SelectedItem?.ToString();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE Usuarios SET Usuario = @usuario, Senha = @senha, TipoUsuario = @tipoUsuario WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                cmd.Parameters.AddWithValue("@Id", usuarioId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário editado com sucesso.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar usuário: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
