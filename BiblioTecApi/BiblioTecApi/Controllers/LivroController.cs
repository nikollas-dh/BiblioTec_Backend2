using BiblioTecApi.Data;
using BiblioTecApi.DTOs;
using BiblioTecApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioTecApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly AppDbContext ct;
        public LivroController(AppDbContext ct)
        {
            this.ct = ct;
        }

        [HttpPost]
        public IActionResult CadastroLivro([FromBody] LivroCadastroDto dto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
				var livro = new Livro(dto);
				ct.Livros.Add(livro);
                ct.SaveChanges();
                return Ok();
            }
            catch (Exception ex) 
            {
                return StatusCode(500, "Erro interno no servidor");
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult listarLivros() 
        {
            var list = ct.Livros.ToList();
            return Ok(list);
        }
	}
}
