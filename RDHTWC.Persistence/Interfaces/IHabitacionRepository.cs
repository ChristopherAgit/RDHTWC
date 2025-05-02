using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Domain.Repositories;

namespace RDHTWC.Persistence.Interfaces
{
    public interface IHabitacionRepository : IBaseRepository<Habitacion>
    {
        Task<OperationResult> GetHabitacionById(int id);
        Task<OperationResult> RemoveHabitacionById(int id);
    }
}
