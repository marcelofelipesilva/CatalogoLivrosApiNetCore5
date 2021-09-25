using CatalogoLivrosApi.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CatalogoLivrosApi.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<CatalogoLivrosDbContext>
    {
        public CatalogoLivrosDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CatalogoLivrosDbContext>();
            CatalogoLivrosDbContext contexto = new CatalogoLivrosDbContext(optionsBuilder.Options);
            return contexto;
        }
    }
}