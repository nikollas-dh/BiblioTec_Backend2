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

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .Properties<Enum>()
                .HaveConversion<string>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasMaxLength(20);
            modelBuilder.Entity<Livro>().Property(l => l.GeneroLivro).HasMaxLength(30);
            modelBuilder.Entity<Livro>().Property(l => l.FormatoLivro).HasMaxLength(20);
        }
    }
}
