using System;

namespace SistemaFazenda2
{
    public class Cliente
    {
        public int cliente_id { get; set; }
        public string Nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
