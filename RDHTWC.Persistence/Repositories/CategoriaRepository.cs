using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Infraestructure.Context;
using RDHTWC.Persistence.Base;
using RDHTWC.Persistence.Interfaces;

namespace RDHTWC.Persistence.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(RDHTWCContext context) : base(context)
        {
        }

        public Task<OperationResult> GetCategoriaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> RemoveCategoriaById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
