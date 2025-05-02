
namespace RDHTWC.Domain.Base
{
    public abstract class AptEntity
    {
        public AptEntity() 
        {
            FechaCreacion = DateTime.Now;
        }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
