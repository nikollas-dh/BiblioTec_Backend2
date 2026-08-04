using BiblioTecApi.Enums;

namespace BiblioTecApi.DTOs
{
    public class LoginResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public Perfil Perfil { get; set; }
        public DateTime Expiracao { get; set; }
    }
}
