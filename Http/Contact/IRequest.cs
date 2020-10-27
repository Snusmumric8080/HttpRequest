using CustomsCalc.Http.Models;

namespace CustomsCalc.Http.IEntity
{
    public interface IRequest
    {
         string GetRequest(RequestModel repos);

         string PostRequest(RequestModel repos);
    }
}
