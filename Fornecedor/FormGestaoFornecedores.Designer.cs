using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace SistemaFazenda2
{
    partial class FormGestaoFornecedores
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditarFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox(); // Caixa de texto para pesquisa
            this.btnBuscar = new System.Windows.Forms.Button(); // Botão para buscar

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.ColumnHeadersHeight = 34;
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(30, 70); // Ajuste a posição
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.RowHeadersWidth = 62;
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewFornecedores.TabIndex = 0;

            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(30, 330);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(199, 35);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar Fornecedor";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);

            // 
            // btnEditarFornecedor
            // 
            this.btnEditarFornecedor.Location = new System.Drawing.Point(262, 330);
            this.btnEditarFornecedor.Name = "btnEditarFornecedor";
            this.btnEditarFornecedor.Size = new System.Drawing.Size(202, 35);
            this.btnEditarFornecedor.TabIndex = 2;
            this.btnEditarFornecedor.Text = "Editar Fornecedor";
            this.btnEditarFornecedor.Click += new System.EventHandler(this.btnEditarFornecedor_Click);

            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(488, 330);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(176, 35);
            this.btnExcluirFornecedor.TabIndex = 3;
            this.btnExcluirFornecedor.Text = "Excluir Fornecedor";
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);

            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(30, 30); // Posição da caixa de texto
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(400, 20);
            this.txtPesquisa.TabIndex = 4;

            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(450, 28); // Posição do botão de busca
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // 
            // FormGestaoFornecedores
            // 
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.dataGridViewFornecedores);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnEditarFornecedor);
            this.Controls.Add(this.btnExcluirFornecedor);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FormGestaoFornecedores";
            this.Text = "Gestão de Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFornecedores;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditarFornecedor;
        private System.Windows.Forms.Button btnExcluirFornecedor;
        private System.Windows.Forms.TextBox txtPesquisa; // Caixa de texto para pesquisa
        private System.Windows.Forms.Button btnBuscar; // Botão para buscar

        // Adicione os métodos para buscar e carregar fornecedores
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.Trim();
            List<Fornecedor> fornecedores = BuscarFornecedores(pesquisa);
            dataGridViewFornecedores.DataSource = fornecedores; // Preenche a DataGridView com os resultados
        }

        private List<Fornecedor> BuscarFornecedores(string pesquisa)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            string connectionString = "Server=CONDLOC_123;Database=SistemaFazendaDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Fornecedores WHERE nome LIKE @Pesquisa OR cnpj_cpf LIKE @Pesquisa";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Pesquisa", "%" + pesquisa + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fornecedor fornecedor = new Fornecedor
                            {
                                fornecedor_id = (int)reader["fornecedor_id"],
                                nome = reader["nome"].ToString(),
                                cnpj_Cpf = reader["cnpj_cpf"].ToString(),
                                endereco = reader["endereco"].ToString(),
                                telefone = reader["telefone"].ToString(),
                                email = reader["email"].ToString()
                            };
                            fornecedores.Add(fornecedor);
                        }
                    }
                }
            }
            return fornecedores; // Retorna a lista de fornecedores encontrados
        }
    }
}
