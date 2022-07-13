namespace Entrevista2.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Idade { get; set; }
        public int? QtdFilhos { get; set; }
        public IEnumerable<Pet>? Pets { get; set; }

        public Pessoa(int id, string nome, int? idade, int? qtdFilhos)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            QtdFilhos = qtdFilhos;
        }
    }
}