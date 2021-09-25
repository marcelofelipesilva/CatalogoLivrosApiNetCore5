using CatalogoLivrosApi.Business.Entities;
using CatalogoLivrosApi.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CatalogoLivrosApi.Infra
{
    public class CatalogoLivrosDbContext : DbContext
    {
        public CatalogoLivrosDbContext(DbContextOptions<CatalogoLivrosDbContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
           
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=172.17.0.6;Database=catalogoLivroApiBD;User Id=sa;Password=App@12345;");
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}