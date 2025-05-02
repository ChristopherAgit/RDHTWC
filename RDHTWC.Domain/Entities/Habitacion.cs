
using RDHTWC.Domain.Base;

namespace RDHTWC.Domain.Entities
{
    public class Habitacion : Vivienda
    {
        public int IdHabitacion {  get; set; }
        public int Numero {  get; set; }
        public string Detalle {  get; set; }
        public string Precio { get; set; }
        public int IdEstadoHabitacion { get; set; }
        public int IdCategoria {  get; set; }
    }
}
