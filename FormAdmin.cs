using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormAdmin : Form

    {
        private const string ConnectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormAdmin()
        {
            InitializeComponent();
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            listViewUsuarios.Items.Clear(); // Limpa a lista antes de carregar

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT Id, Usuario, TipoUsuario FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Usuario"].ToString());
                        item.SubItems.Add(reader["TipoUsuario"].ToString());
                        listViewUsuarios.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
                }
            }
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            // Passa o tipo de usuário atual para o formulário de adição, se necessário
            FormAdicionarUsuario formAdicionar = new FormAdicionarUsuario();

            // Verifica se o diálogo foi fechado com sucesso
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                CarregarUsuarios(); // Recarrega a lista de usuários após adicionar
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (listViewUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem itemSelecionado = listViewUsuarios.SelectedItems[0];
            int usuarioId = Convert.ToInt32(itemSelecionado.SubItems[0].Text);
            string usuario = itemSelecionado.SubItems[1].Text;
            string tipoUsuario = itemSelecionado.SubItems[2].Text;

            // Aqui você pode implementar a lógica para obter a senha, se necessário
            string senha = ""; // Obtenha a senha do usuário se necessário

            FormEditarUsuario formEditar = new FormEditarUsuario(usuarioId, usuario, senha, tipoUsuario);
            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                CarregarUsuarios(); // Recarrega a lista de usuários após editar
            }
        }
        
        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            

            if (listViewUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar a exclusão
            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir o usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                ListViewItem itemSelecionado = listViewUsuarios.SelectedItems[0];
                int usuarioId = Convert.ToInt32(itemSelecionado.SubItems[0].Text);

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    string query = "DELETE FROM Usuarios WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", usuarioId);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário excluído com sucesso.");
                        CarregarUsuarios(); // Atualiza a lista após a exclusão
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
                    }
                }
            }
        }
    }
}
