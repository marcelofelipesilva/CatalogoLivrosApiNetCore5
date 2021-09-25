using System.Collections.Generic;
using CatalogoLivrosApi.Business.Entities;

namespace CatalogoLivrosApi.Business.IRepositories
{
    public interface ILivroRepository
    {
        void Adicionar(Livro livro);
        void Commit();

        List<Livro> obterlivros(int LivroID);
        
    }
}