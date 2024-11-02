namespace SistemaFazenda2
{
    public class Produto
    {
        public int produto_id { get; set; } // ID do produto
        public string nome { get; set; } // Nome do produto
        public string codigo { get; set; } // Código do produto
        public decimal preco { get; set; } // Preço do produto
        public int quantidade { get; set; } // Quantidade disponível em estoque
        public string descricao { get; set; } // Descrição do produto

        // Você pode adicionar outros métodos ou propriedades conforme necessário
    }
}
