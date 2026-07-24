using BiblioTecApi.DTOs;
using BiblioTecApi.Enums;

namespace BiblioTecApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha{ get; set; }
        public DateTime DataNascimento{ get; set; }
        public string Celular{ get; set; }
        public int CursoId{ get; set; }
        public Perfil Perfil { get; set; }

        public Usuario() { }
        public Usuario (UsuarioCadastroDto dto)
        {
            
            Nome = dto.Nome;
            Email = dto.Email;
            Senha = dto.Senha;
            DataNascimento = dto.Data_nascimento;
            Celular = dto.Celular;
            CursoId = dto.CursoId;
            Perfil = dto.Perfil;
        }
    }
}
