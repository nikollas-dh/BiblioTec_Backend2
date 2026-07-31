using BiblioTecApi.Enums;
using BiblioTecApi.DTOs;
using BiblioTecApi.Enums;
namespace BiblioTecApi.Models
{
    public class Livro
    {
        public int Id{ get; set; } 
        public string Titulo{ get; set; }
        public string Autor{ get; set; }
        public GeneroLivro GeneroLivro { get; set; }
        public string Editora{ get; set; }
        public int AnoPublicacao{ get; set; }
        public string Isbn { get; set; }
        public string Idioma { get; set; }
        public Formatolivro FormatoLivro { get; set; }
        public string Caminho_capa { get; set; }
        public string Sinopse { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

        public Livro() { }
        public Livro(LivroCadastroDto dto)
        {
            Titulo = dto.Titulo;
            Autor = dto.Autor;
            GeneroLivro = dto.GeneroLivro;
            Editora = dto.Editora;
            AnoPublicacao = dto.AnoPublicacao;
            Isbn = dto.Isbn;
            Idioma = dto.Idioma;
            FormatoLivro = dto.FormatoLivro;
            Caminho_capa = dto.CaminhoCapa;
            Sinopse = dto.Sinopse;
            Ativo = true;
            CriadoEm = DateTime.UtcNow ;
            AtualizadoEm = DateTime.UtcNow ;
        }
    }
}
