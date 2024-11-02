namespace SistemaFazenda2
{
    public class Item
    {
        public int Id { get; set; }        // ID do item
        public string Nome { get; set; }   // Nome do item
        public int Quantidade { get; set; } // Quantidade do item
        public decimal Preco { get; set; }  // Preço do item

        // Construtor da classe Item (opcional, mas pode ajudar na criação de novos objetos Item)
        public Item(int id, string nome, int quantidade, decimal preco)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        // Construtor vazio (necessário caso você precise instanciar a classe sem passar valores)
        public Item() { }
    }
}
