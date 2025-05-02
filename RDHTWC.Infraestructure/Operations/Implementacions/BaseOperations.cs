using RDHTWC.Domain.Base;
using RDHTWC.Infraestructure.Operations.Interfaces;

namespace RDHTWC.Infraestructure.Operations.Implementacions
{
    public class BaseOperations : IBaseOperations
    {

        public OperationResult SuccesOperation(dynamic data , string message)
        {
            OperationResult result = new OperationResult();
            
            result.Data = data;
            result.Succes = true;
            result.Messagge = message;
            return result;
        }

        public OperationResult HandleException(string message, Exception? exception)
        {
            OperationResult result = new OperationResult();
            
            result.Messagge = $"{message} : {exception.Message}";
            return result;

        }

    }
}
