using BiblioTecApi.Data;
using BiblioTecApi.DTOs;
using BiblioTecApi.Models;
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
            //if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                var livro = new Livro
                {
                    Titulo = dto.Titulo,
                    Autor = dto.Autor,
                    AnoPublicacao = dto.AnoPublicacao,
                    Formato = dto.Formato,
                    Editora = dto.Editora,
                    Isbn = dto.Isbn,
                    Sinopse = dto.Sinopse,
                    Idioma = dto.Idioma,
                    Genero = dto.Genero,
                    Caminho_capa = dto.CaminhoCapa,
                };
                ct.Livros.Add(livro);
                ct.SaveChanges();
                return Ok();
            }
            catch (Exception ex) 
            {
                return StatusCode(500, "Erro interno no servidor");
            }
        }
    } 
}
