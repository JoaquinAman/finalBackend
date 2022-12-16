using System.Net;

namespace BakeryFinal.Exceptions
{
    public interface IServiceException
    {
        public HttpStatusCode StatusCode { get; }
        public string ErrorMessage { get; }

    }
}
