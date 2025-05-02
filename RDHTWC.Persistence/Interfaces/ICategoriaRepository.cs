using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Domain.Repositories;

namespace RDHTWC.Persistence.Interfaces
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        Task<OperationResult> GetCategoriaById(int id);
        Task<OperationResult> RemoveCategoriaById(int id);

    }
}
