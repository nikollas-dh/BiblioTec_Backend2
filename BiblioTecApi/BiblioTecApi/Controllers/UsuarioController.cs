using BiblioTecApi.Data;
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

        [HttpPost]
        public IActionResult CadastroUsuario([FromBody] Usuario usuario)
        {
            try
            {
                ct.Usuarios.Add(usuario);
                ct.SaveChanges();
                return Ok("Usuário cadastrado com sucesso");
            } catch (Exception ex) {
                return StatusCode(500, "Erro interno no servidor!");
            }
        }
    }
}
