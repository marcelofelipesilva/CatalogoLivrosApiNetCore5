using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoLivrosApi.Business.Entities
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }
        [StringLength(10)]
        public string Login { get; set; }
        [StringLength(8)]
        public string Senha { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
    }
}