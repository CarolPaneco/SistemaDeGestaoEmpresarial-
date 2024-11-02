using System;

public class Venda
{
    public int venda_id { get; set; }  // Exemplo de campo de identificação da venda
    public int produto_id { get; set; }  // ID do produto
    public int quantidade { get; set; }  // Quantidade vendida
    public decimal preco_total { get; set; }  // Preço total da venda

    // Adicione a propriedade ClienteId, se for relevante
    public int cliente_id { get; set; }  // ID do cliente

    public DateTime data_venda { get; set; }
}
