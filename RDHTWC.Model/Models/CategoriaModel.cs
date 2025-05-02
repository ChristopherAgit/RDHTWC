namespace RDHTWC.Model.Models
{
    public class CategoriaModel
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public int IdServicio { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
