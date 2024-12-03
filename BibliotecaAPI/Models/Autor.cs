using System.Collections.Generic;

namespace BibliotecaAPI.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string Biografia { get; set; }

        // Relacionamento muitos-para-muitos com Livro
        public ICollection<LivroAutor> LivrosAutores { get; set; }
    }
}
