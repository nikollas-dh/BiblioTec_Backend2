using BiblioTecApi.Enums;
using BiblioTecApi.Models;
using System.ComponentModel.DataAnnotations;

namespace BiblioTecApi.DTOs
{
    public class UsuarioCadastroDto
    {
        [Required]
        [StringLength(100, MinimumLength =3)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength (100, MinimumLength = 3)]
        public string Email { get; set; }
        
        [Required]
        public string Senha { get; set; }
        
        [Required]
        public DateTime Data_nascimento { get; set; }
        
        [Required]
        [RegularExpression(@"^\d{11}",ErrorMessage ="O celular deve conter 11 digitos numéricos!")]
        public string Celular { get; set; }
        
        [Required]
        public int CursoId { get; set; }
        
        [Required]
        public Perfil Perfil { get; set; }
    }
}

