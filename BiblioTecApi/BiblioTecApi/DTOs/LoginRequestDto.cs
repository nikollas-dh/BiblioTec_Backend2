using System.ComponentModel.DataAnnotations;

namespace BiblioTecApi.DTOs
{
    public class LoginRequestDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
