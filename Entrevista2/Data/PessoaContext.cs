using Entrevista2.Models;
using Microsoft.EntityFrameworkCore;

namespace Entrevista2.Data
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options) { }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasData
            (
                new Pessoa(1, "Paulo", 38, 1),
                new Pessoa(2, "Priscila", 34, 1),
                new Pessoa(3, "Bruno", 36, 1),
                new Pessoa(4, "Julia", 13, 0),
                new Pessoa(5, "Pedro", 30, 1),
                new Pessoa(6, "Rosa", 45, 3),
                new Pessoa(7, "Fatima", 60, 2),
                new Pessoa(8, "Maria", 31, 0),
                new Pessoa(9, "Rodrigo", 20, 0),
                new Pessoa(10, "Rita", 18, 0)
            );

            modelBuilder.Entity<Pet>().HasData
            (
                new Pet(1, "Cachorro", "Rex", 1),
                new Pet(2, "Cachorro", "Roy", 1),
                new Pet(3, "Cachorro", "Pit"),
                new Pet(4, "Cachorro", "Tom"),
                new Pet(5, "Cachorro", "Clark", 4),
                new Pet(6, "Cachorro", "Bat", 4),
                new Pet(7, "Cachorro", "Spider"),
                new Pet(8, "Gato", "Mingal", 6),
                new Pet(9, "Gato", "Ross"),
                new Pet(10, "Gato", "Kramer", 6),
                new Pet(11, "Gato", "Chandler"),
                new Pet(12, "Gato", "Phoebe", 8),
                new Pet(13, "Gato", "Rachel"),
                new Pet(14, "Gato", "Jerry", 10)
            ); 
        }
    }
}