
using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Domain.Repositories;

namespace RDHTWC.Persistence.Interfaces
{
    public interface IEstadoHabitacionRepository : IBaseRepository<EstadoHabitacion>
    {
        Task<OperationResult> GetEstadoHabitacionById(int id);
        Task<OperationResult> RemoveEstadoHabitacionById(int id);
    }
}
