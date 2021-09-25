using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoLivrosApi.Business.Entities
{
    public class Livro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LivroID { get; set; }
        [StringLength(50)]
        public string Titulo { get; set; }
        [StringLength(50)]
        public string Isbn { get; set; }
        [StringLength(40)]
        public string Autor { get; set; }
        [StringLength(50)]
        public string Editora { get; set; }
        [StringLength(400)]
        public string Sinopse { get; set; } 
        
    }
}