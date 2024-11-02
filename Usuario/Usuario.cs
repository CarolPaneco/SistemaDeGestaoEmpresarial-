using System;

namespace SistemaFazenda2
{
    public class Usuario
    {
        public int Id { get; set; }                // Identificador único do usuário
        public string NomeUsuario { get; set; }    // Nome de usuário
        public string Senha { get; set; }           // Senha do usuário
        public string TipoUsuario { get; set; }     // Tipo de usuário (por exemplo, Admin, Usuario)

        // Construtor
        public Usuario(int id, string nomeUsuario, string senha, string tipoUsuario)
        {
            Id = id;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        // Método para exibir informações do usuário (opcional)
        public override string ToString()
        {
            return $"Id: {Id}, Nome: {NomeUsuario}, Tipo: {TipoUsuario}";
        }
    }
}
