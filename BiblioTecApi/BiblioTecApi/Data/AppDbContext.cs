using BiblioTecApi.Models;
using Microsoft.EntityFrameworkCore;


namespace BiblioTecApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Livro> Livros{ get; set; }
        public DbSet<Curso> Cursos{ get; set; }
    }
}
