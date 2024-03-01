using System;

namespace ModuloAPI.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }

        // Construtor que inicializa as propriedades obrigatórias
        public Contato()
        {
            Nome = string.Empty;
            Telefone = string.Empty;
            Ativo = false;
        }
    }
}
