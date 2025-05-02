
using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Domain.Repositories;

namespace RDHTWC.Persistence.Interfaces
{
    public interface IPisoRepository : IBaseRepository<Piso>
    {
        Task<OperationResult> GetPisoById(int id);
        Task<OperationResult> RemovePisoById(int id);
    }
}
