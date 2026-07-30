using BiblioTecApi.Data;
using BiblioTecApi.DTOs;

namespace BiblioTecApi.Services
{
    public class AuthService
    {
        private readonly AppDbContext ct;
        private readonly TokenService tk;

        public AuthService(AppDbContext ct, TokenService tk)
        {
            this.ct = ct;
            this.tk = tk;
        }

        public LoginResponseDto Login(LoginRequestDto dto)
        {
            var us = ct.Usuarios.FirstOrDefault(u => u.Email == dto.Email);
            if (us == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            bool senhaValida = BCrypt.Net.BCrypt.Verify(dto.Senha, us.Senha);
            if (!senhaValida) throw new Exception("Usuário ou senha inválidos");

            return new LoginResponseDto
            {
                Token = tk.GerarToken(us),
                Expiracao = DateTime.Now.AddMinutes(60)
            };

        }
    }
}
