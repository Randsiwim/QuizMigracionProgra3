namespace ControlMigracion.Models
{
    public class Movimiento
    {
        public int MovimientoID { get; set; }
        public int ViajeroID { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime Fecha { get; set; }
        public int LugarID { get; set; }

        public Viajero Viajero { get; set; }
        public Lugar Lugar { get; set; }
    }
}
