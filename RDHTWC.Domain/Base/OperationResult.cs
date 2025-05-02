
namespace RDHTWC.Domain.Base
{
    public class OperationResult
    {
        public OperationResult() 
        {
            Succes = false;
        }
        public bool Succes {  get; set; }
        public string Messagge {  get; set; }
        public dynamic Data {  get; set; }
        
    }
}
