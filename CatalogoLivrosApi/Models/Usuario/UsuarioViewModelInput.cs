using System.ComponentModel.DataAnnotations;

namespace CatalogoLivrosApi.Models.Usuario
{
    public class UsuarioViewModelInput
    {
        [Required(ErrorMessage = "O campo login é obrigatório.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; set; }
    }
}