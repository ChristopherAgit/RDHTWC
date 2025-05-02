
using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Infraestructure.Context;
using RDHTWC.Persistence.Base;
using RDHTWC.Persistence.Interfaces;
using System.Linq.Expressions;

namespace RDHTWC.Persistence.Repositories
{
    public class EstadoHabitacionRepository : BaseRepository<EstadoHabitacion>, IEstadoHabitacionRepository
    {
        public EstadoHabitacionRepository(RDHTWCContext context) : base(context)
        {

        }

        public Task<OperationResult> GetEstadoHabitacionById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> RemoveEstadoHabitacionById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
