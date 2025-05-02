
using RDHTWC.Domain.Base;

namespace RDHTWC.Domain.Entities
{
    public class Cliente : AptEntity
    {
        public int IdCliente {  get; set; }
        public string ?TipoDocumento {  get; set; }
        public string ?Documento { get; set; }
        public string ?NombreCompleto {  get; set; }
        public string ?Correo {  get; set; }
    }
}
