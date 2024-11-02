using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormGestaoVenda : Form
    {
        private const string ConnectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormGestaoVenda()
        {
            InitializeComponent();
            CarregarVendas();
        }

        private void CarregarVendas(string filtro = "")
        {
            List<Venda> vendas = ObterVendas(filtro);
            dataGridViewVendas.DataSource = vendas;
        }

        private List<Venda> ObterVendas(string filtro)
        {
            List<Venda> vendas = new List<Venda>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Vendas";

                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE CAST(venda_id AS VARCHAR) LIKE @filtro OR CAST(produto_id AS VARCHAR) LIKE @filtro OR CAST(cliente_id AS VARCHAR) LIKE @filtro";
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
                            Venda venda = new Venda
                            {
                                venda_id = (int)reader["venda_id"],
                                produto_id = reader["produto_id"] != DBNull.Value ? (int)reader["produto_id"] : 0,
                                quantidade = reader["quantidade"] != DBNull.Value ? (int)reader["quantidade"] : 0,
                                preco_total = reader["preco_total"] != DBNull.Value ? (decimal)reader["preco_total"] : 0m,
                                data_venda = (DateTime)reader["data_venda"],
                                cliente_id = reader["cliente_id"] != DBNull.Value ? (int)reader["cliente_id"] : 0
                            };
                            vendas.Add(venda);
                        }
                    }
                }
            }
            return vendas;
        }

        private void btnAdicionarVenda_Click(object sender, EventArgs e)
        {
            FormAdicionarVenda formAdicionar = new FormAdicionarVenda();
            formAdicionar.FormClosed += (s, args) => CarregarVendas();
            formAdicionar.Show();
        }

        private void btnEditarVenda_Click(object sender, EventArgs e)
        {
            if (dataGridViewVendas.SelectedRows.Count > 0)
            {
                var vendaSelecionada = (Venda)dataGridViewVendas.SelectedRows[0].DataBoundItem;
                FormEditarVenda formEditar = new FormEditarVenda(vendaSelecionada);
                formEditar.FormClosed += (s, args) => CarregarVendas();
                formEditar.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma venda para editar.");
            }
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            if (dataGridViewVendas.SelectedRows.Count > 0)
            {
                var vendaSelecionada = (Venda)dataGridViewVendas.SelectedRows[0].DataBoundItem;
                ExcluirVenda(vendaSelecionada.venda_id);
                CarregarVendas();
            }
            else
            {
                MessageBox.Show("Selecione uma venda para excluir.");
            }
        }

        private void ExcluirVenda(int vendaId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Vendas WHERE venda_id = @VendaId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendaId", vendaId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnBuscarVenda_Click(object sender, EventArgs e)
        {
            // Obter o texto de busca da caixa de texto
            string termoBusca = txtBuscarVenda.Text.Trim();
            // Chamar o método CarregarVendas com o termo de busca
            CarregarVendas(termoBusca);
        }
    }
}
