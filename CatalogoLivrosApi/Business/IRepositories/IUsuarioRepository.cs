using System.Collections.Generic;
using CatalogoLivrosApi.Business.Entities;

namespace CatalogoLivrosApi.Business.IRepositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Commit();

        List<Usuario> obterlivros(int UsuarioID);
    }
}