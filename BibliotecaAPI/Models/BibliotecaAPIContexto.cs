using Microsoft.EntityFrameworkCore;
namespace BibliotecaAPI.Models
{
    public class BibliotecaAPIContexto : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroAutor>()
                .HasKey(la => new { la.LivroId, la.AutorId });

            modelBuilder.Entity<LivroAutor>()
                .HasOne(la => la.Livro)
                .WithMany(l => l.LivrosAutores)
                .HasForeignKey(la => la.LivroId);

            modelBuilder.Entity<LivroAutor>()
                .HasOne(la => la.Autor)
                .WithMany(a => a.LivrosAutores)
                .HasForeignKey(la => la.AutorId);
        }
    }
}
