using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SistemaFazenda2
{
    public partial class FormRelatorioVendas : Form
    {
        private const string ConnectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

        public FormRelatorioVendas()
        {
            InitializeComponent();
        }

        private void FormRelatorioVendas_Load(object sender, EventArgs e)
        {
            // Carregar o relatório de vendas completo na inicialização
            CarregarRelatorio();
        }

        private void CarregarRelatorio(DateTime? dataInicio = null, DateTime? dataFim = null)
        {
            List<Venda> vendas = ObterVendas(dataInicio, dataFim);

            // Configurar DataGridView com os dados das vendas
            dataGridViewRelatorio.DataSource = vendas;

            // Exibir totais resumidos
            lblTotalVendas.Text = vendas.Count.ToString();
            lblTotalItensVendidos.Text = vendas.Sum(v => v.quantidade).ToString();
            lblReceitaTotal.Text = vendas.Sum(v => v.preco_total).ToString("C2");
        }

        private List<Venda> ObterVendas(DateTime? dataInicio, DateTime? dataFim)
        {
            List<Venda> vendas = new List<Venda>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Vendas WHERE (@DataInicio IS NULL OR data_venda >= @DataInicio) AND (@DataFim IS NULL OR data_venda <= @DataFim)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DataInicio", (object)dataInicio ?? DBNull.Value);
                    command.Parameters.AddWithValue("@DataFim", (object)dataFim ?? DBNull.Value);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venda venda = new Venda
                            {
                                venda_id = (int)reader["venda_id"],
                                produto_id = (int)reader["produto_id"],
                                quantidade = (int)reader["quantidade"],
                                preco_total = (decimal)reader["preco_total"],
                                data_venda = (DateTime)reader["data_venda"],
                                cliente_id = (int)reader["cliente_id"]
                            };
                            vendas.Add(venda);
                        }
                    }
                }
            }
            return vendas;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Captura as datas de filtro dos DateTimePickers e carrega o relatório com filtro
            DateTime? dataInicio = dtpInicio.Checked ? dtpInicio.Value : (DateTime?)null;
            DateTime? dataFim = dtpFim.Checked ? dtpFim.Value : (DateTime?)null;

            CarregarRelatorio(dataInicio, dataFim);
        }
    }
}
