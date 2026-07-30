using BCrypt.Net;
using BiblioTecApi.Data;
using BiblioTecApi.DTOs;
using BiblioTecApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioTecApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext ct;

        public UsuarioController(AppDbContext ct)
        {
            this.ct = ct;
        }

        //[HttpPost]
        //public IActionResult CadastroUsuario([FromBody] Usuario usuario)
        //{
        //    try
        //    {
        //        ct.Usuarios.Add(usuario);
        //        ct.SaveChanges();
        //        return Ok("Usuário cadastrado com sucesso");
        //    } catch (Exception ex) {
        //        return StatusCode(500, "Erro interno no servidor!");
        //    }
        //}

        [HttpPost]
        public IActionResult CadastroUsuario([FromBody] UsuarioCadastroDto dto)
        {
            try
            {
                if(!ModelState.IsValid) return BadRequest(ModelState);

                var usuario = new Usuario 
                {
                    Nome = dto.Nome,
                    Email = dto.Email,
                    Senha = BCrypt.Net.BCrypt.HashPassword(dto.Senha),
                    DataNascimento = dto.Data_nascimento,
                    Celular = dto.Celular,
                    CursoId = dto.CursoId,
                    Perfil = dto.Perfil,
                };
                
                
                ct.Usuarios.Add(usuario);
                ct.SaveChanges();
                return CreatedAtAction(nameof(CadastroUsuario), new
                {
                    usuario.Id,
                    usuario.Nome,
                    usuario.Email
                });
            }
            catch (Exception) 
            {
                return StatusCode(500, "Erro interno no servidor!");
            }
        }    
    }
}
