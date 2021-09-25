using System.Collections.Generic;
using System.Linq;
using CatalogoLivrosApi.Business.Entities;
using CatalogoLivrosApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace CatalogoLivrosApi.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CatalogoLivrosDbContext _context;

        public UsuarioRepository(CatalogoLivrosDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Usuario usuario)
        {
           _context.Add(usuario);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        
        public List<Usuario> obterUsuarios(int UsuarioID)
        {
            return _context.Usuarios.Include(i => i.UsuarioID).Where(w => w.UsuarioID == UsuarioID).ToList();

        }
    }
}