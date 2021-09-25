using System.Collections.Generic;
using System.Linq;
using CatalogoLivrosApi.Business.Entities;
using CatalogoLivrosApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace CatalogoLivrosApi.Infra.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly CatalogoLivrosDbContext _context;

        public LivroRepository(CatalogoLivrosDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Livro livro)
        {
            _context.Add(livro);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public List<Livro> obterlivros(int LivroID)
        {
            return _context.Livros.Include(i => i.LivroID).Where(w => w.LivroID == LivroID).ToList();
        }
    }
}