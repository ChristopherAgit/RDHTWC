using RDHTWC.Domain.Base;
using RDHTWC.Domain.Entities;
using RDHTWC.Infraestructure.Context;
using RDHTWC.Persistence.Base;
using RDHTWC.Persistence.Interfaces;

namespace RDHTWC.Persistence.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(RDHTWCContext context) : base(context)
        {

        }

        public Task<OperationResult> GetClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult> RemoveClienteById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
