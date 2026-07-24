using BiblioTecApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace BiblioTecApi.DTOs
{
    public class LivroCadastroDto
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Autor { get; set; } 

        [Required]
        public Genero Genero { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Editora { get; set; } 

        public int AnoPublicacao { get; set; }

        [StringLength(20)]
        public string Isbn { get; set; }

        [StringLength(50)]
        public string Idioma { get; set; } 

        [Required]
        public Formato Formato { get; set; }

        [StringLength(255)]
        public string CaminhoCapa { get; set; } 

        [StringLength(1000)]
        public string Sinopse { get; set; } 
    }
}