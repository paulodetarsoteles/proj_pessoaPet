using System.Text.Json.Serialization;

namespace Entrevista2.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Especie { get; set; }
        public string? Nome { get; set; }
        public int? PessoaId { get; set; }
        [JsonIgnore]
        public Pessoa? Pessoa { get; set; }

        public Pet(int id, string especie, string? nome)
        {
            Id = id;
            Especie = especie;
            Nome = nome;
        }

        public Pet(int id, string especie, string? nome, int pessoaId) : this(id, especie, nome)
        {
            PessoaId = pessoaId;
        }
    }
}