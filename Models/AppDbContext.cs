using Microsoft.EntityFrameworkCore;
using mvc1.Models;

namespace AspNetCoreDocker.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  
        {   

        } 

        public DbSet<Produto> Produtos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Nome)
                    .HasMaxLength(80);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Categoria)
                    .HasMaxLength(80);
         
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                    .HasPrecision(10,2);

            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto {ProdutoId = 1,Nome = "Sabão", Categoria = "Banho", Preco = 2},
                    new Produto {ProdutoId = 2,Nome = "Fogão", Categoria = "Cozinha", Preco = 1000},
                    new Produto {ProdutoId = 3,Nome = "Televisão", Categoria = "Eletrodoméstico", Preco = 2500}
                );

                 
        }
    }
}