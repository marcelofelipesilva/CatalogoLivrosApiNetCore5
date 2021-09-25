using System.Linq;
using CatalogoLivrosApi.Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CatalogoLivrosApi.Configurations
{
    public static class EntityFrameworkExtensions {
      
        public static IApplicationBuilder UseApplyMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var CatalogoLivrosDbContext = serviceScope.ServiceProvider.GetService<CatalogoLivrosDbContext>())
                {
                    var migracoesPendentes = CatalogoLivrosDbContext.Database.GetPendingMigrations();

                    if (migracoesPendentes.Count() == 0)
                    {
                        return app;
                    }

                    CatalogoLivrosDbContext.Database.Migrate();
                }
            }

            return app;
        }
    }
}