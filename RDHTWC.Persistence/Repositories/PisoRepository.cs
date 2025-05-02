using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Infraestructure.Context;
using RDHTWC.Persistence.Base;
using RDHTWC.Persistence.Interfaces;

namespace RDHTWC.Persistence.Repositories
{
    public class PisoRepository : BaseRepository<Piso>, IPisoRepository
    {
        public PisoRepository(RDHTWCContext context) : base(context)
        {

        }

        public Task<OperationResult> GetPisoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> RemovePisoById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
