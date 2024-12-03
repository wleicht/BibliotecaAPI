using System;

namespace BibliotecaAPI.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataReserva { get; set; }
    }
}
