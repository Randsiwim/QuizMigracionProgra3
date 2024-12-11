using QuizMigracion.Models;

namespace ControlMigracion.Models
{
    public class Viajero
    {
        public int ViajeroID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Pasaporte { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ICollection<Movimiento> Movimientos { get; set; }
    }
}
