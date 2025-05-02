
using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Domain.Repositories;

namespace RDHTWC.Persistence.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<OperationResult> GetClienteById(int id);
        Task<OperationResult> RemoveClienteById(int id);
    }
}
