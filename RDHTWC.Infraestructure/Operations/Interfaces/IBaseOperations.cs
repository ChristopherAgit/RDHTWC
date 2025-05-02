
using RDHTWC.Domain.Base;

namespace RDHTWC.Infraestructure.Operations.Interfaces
{
    public interface IBaseOperations
    {
        public OperationResult SuccesOperation(dynamic data, string message);
        public OperationResult HandleException(string messague, Exception? exception);
    }
}
