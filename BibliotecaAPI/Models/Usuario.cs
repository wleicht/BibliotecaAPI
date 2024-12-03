namespace BibliotecaAPI.Models
{
    public class Usuario
    {
        public enum TipoUsuario { Comum, Admin }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario Tipo { get; set; }
    }
}
