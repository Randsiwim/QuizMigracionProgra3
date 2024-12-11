namespace ControlMigracion.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int RolID { get; set; }
        public Rol Rol { get; set; }
    }
}
