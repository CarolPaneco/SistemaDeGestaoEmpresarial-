using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaFazenda2;

namespace SistemaVenda
{
    public partial class FormSelecionarCliente : Form
    {
        public int ClienteId { get; set; }

        private string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormSelecionarCliente()
        {
            InitializeComponent();
        }

        private void FormSelecionarCliente_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT cliente_id, nome FROM Clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Configurações da ListBox
                listBoxClientes.DataSource = dt;
                listBoxClientes.DisplayMember = "nome";
                listBoxClientes.ValueMember = "cliente_id";
            }
        }



        private void btnSelecionarCliente_Click_1(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                // Obtenha o ClienteId selecionado
                ClienteId = (int)((DataRowView)listBoxClientes.SelectedItem)["cliente_id"];

                // Crie uma instância de FormAdicionarProduto1 e passe o ClienteId
                FormAdicionarProduto1 formAdicionarProduto = new FormAdicionarProduto1(ClienteId);

                // Mostre o formulário
                formAdicionarProduto.Show();
            }
            else
            {
                MessageBox.Show("Selecione um cliente!");
            }
        }

    }
}
