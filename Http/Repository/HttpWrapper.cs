using CustomsCalc.Http.Contact;
using CustomsCalc.Http.IEntity;

namespace CustomsCalc.Http.Repository
{
    public class HttpWrapper : IHttpWrapper
    {
        Request _request;

        public IRequest Request
        {
            get
            {
                if (_request == null)
                {
                    _request = new Request();
                }
                return _request;
            }
        }

    }
}
