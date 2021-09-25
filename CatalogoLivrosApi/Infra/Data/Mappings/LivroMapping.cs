using CatalogoLivrosApi.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatalogoLivrosApi.Infra.Data.Mappings
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("TB_Livro");
            builder.HasKey(p => p.LivroID);
            builder.Property(p => p.LivroID).ValueGeneratedOnAdd();
            builder.Property(p => p.Titulo);
            builder.Property(p => p.Isbn);
            builder.Property(p => p.Autor);
            builder.Property(p => p.Editora);
            builder.Property(p => p.Sinopse);
        }
    }
}