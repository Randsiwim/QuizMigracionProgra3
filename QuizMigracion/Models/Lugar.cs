using QuizMigracion.Models;

namespace ControlMigracion.Models
{
    public class Lugar
    {
        public int LugarID { get; set; }
        public string NombreLugar { get; set; }
        public ICollection<Movimiento> Movimientos { get; set; }
    }
}
