using Microsoft.EntityFrameworkCore;
using RDHTWC.Domain.Entities;

namespace RDHTWC.Infraestructure.Context
{
    public class RDHTWCContext : DbContext
    {
        public RDHTWCContext(DbContextOptions<RDHTWCContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EstadoHabitacion> EstadoHabitacion { get; set; }
        public DbSet<Habitacion> Habitacion { get; set; }
        public DbSet<Piso> Piso { get; set; }

    }
}
