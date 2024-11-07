using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaFazenda2;

namespace SistemaFazenda2
{
    public partial class FormRelatorioVendas : Form
    {
        public FormRelatorioVendas()
        {
            InitializeComponent();
        }

        private void FormRelatorioVendas_Load(object sender, EventArgs e)
        {
            CarregarRelatorioVendas();
        }

        private void CarregarRelatorioVendas()
        {
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";
            string query = @"
                SELECT 
                    V.venda_id, 
                    C.nome AS cliente, 
                    V.data_venda, 
                    P.nome AS produto, 
                    IV.quantidade, 
                    IV.preco_unitario, 
                    (IV.quantidade * IV.preco_unitario) AS preco_total
                FROM 
                    Vendas V
                INNER JOIN 
                    Clientes C ON V.cliente_id = C.cliente_id
                INNER JOIN 
                    ItensVenda IV ON V.venda_id = IV.venda_id
                INNER JOIN 
                    Produtos P ON IV.produto_id = P.produto_id
                ORDER BY 
                    V.venda_id";

            // Variáveis para somar os totais
            int totalItensVendidos = 0;
            decimal totalValorVendido = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Define as colunas manualmente para manter ordem e nomenclatura
                dataGridViewVendas.Columns.Clear();
                dataGridViewVendas.AutoGenerateColumns = false;

                dataGridViewVendas.Columns.Add("VendaID", "ID Venda");
                dataGridViewVendas.Columns["VendaID"].DataPropertyName = "venda_id";

                dataGridViewVendas.Columns.Add("Cliente", "Cliente");
                dataGridViewVendas.Columns["Cliente"].DataPropertyName = "cliente";

                dataGridViewVendas.Columns.Add("DataVenda", "Data da Venda");
                dataGridViewVendas.Columns["DataVenda"].DataPropertyName = "data_venda";

                dataGridViewVendas.Columns.Add("Produto", "Produto");
                dataGridViewVendas.Columns["Produto"].DataPropertyName = "produto";

                dataGridViewVendas.Columns.Add("Quantidade", "Quantidade");
                dataGridViewVendas.Columns["Quantidade"].DataPropertyName = "quantidade";

                dataGridViewVendas.Columns.Add("PrecoUnitario", "Preço Unitário");
                dataGridViewVendas.Columns["PrecoUnitario"].DataPropertyName = "preco_unitario";

                dataGridViewVendas.Columns.Add("PrecoTotal", "Preço Total");
                dataGridViewVendas.Columns["PrecoTotal"].DataPropertyName = "preco_total";

                // Acumula os totais durante o preenchimento do DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    totalItensVendidos += Convert.ToInt32(row["quantidade"]);
                    totalValorVendido += Convert.ToDecimal(row["preco_total"]);
                }

                dataGridViewVendas.DataSource = dataTable;

                // Atualiza as labels com os totais
                lblTotalItens.Text = "Total de Itens Vendidos: " + totalItensVendidos.ToString();
                lblValorTotal.Text = "Valor Total Vendido: R$ " + totalValorVendido.ToString("N2");
            }
        }
    }
}
