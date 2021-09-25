using System.ComponentModel.DataAnnotations;

namespace CatalogoLivrosApi.Models.Livro
{
    public class LivroViewModelInput
    {
        [Required(ErrorMessage = "o campo titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "o campo Isbn é obrigatório")]
        public string Isbn { get; set; }
        [Required(ErrorMessage = "o campo Autor é obrigatório")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "o campo Editora é obrigatório")]
        public string Editora { get; set; }
        [Required(ErrorMessage = "o campo Sinopse é obrigatório")]
        public string Sinopse { get; set; } 
    }
}