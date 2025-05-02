
namespace RDHTWC.Model.Models
{
    public class HabitacionModel
    {
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        public string Detalle { get; set; }
        public string Precio { get; set; }
        public int IdEstadoHabitacion { get; set; }
        public int IdCategoria { get; set; }
        public int IdPiso { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
