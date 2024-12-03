using System.Collections.Generic;

namespace BibliotecaAPI.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int NumeroExemplares { get; set; }

        
        public ICollection<LivroAutor> LivrosAutores { get; set; }
    }
}
