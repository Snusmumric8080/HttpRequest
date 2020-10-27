using CustomsCalc.Http.IEntity;

namespace CustomsCalc.Http.Contact
{
    public interface IHttpWrapper
    {
        IRequest Request { get; }
    }
}
