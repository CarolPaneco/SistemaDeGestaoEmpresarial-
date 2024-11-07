using System;

namespace SistemaFazenda2
{
    public class Produto
    {
        public int produto_id { get; set; }              // ID do produto
        public string nome { get; set; }                  // Nome do produto
        public string descricao { get; set; }             // Descrição do produto
        public decimal preco { get; set; }                 // Preço do produto
        public int quantidade_em_estoque { get; set; }   // Quantidade em estoque

        public DateTime data_adicao { get; set; }         // Data de adição do produto
        public decimal preco_unitario { get; set; }       // Preço unitário do produto
    }
}
