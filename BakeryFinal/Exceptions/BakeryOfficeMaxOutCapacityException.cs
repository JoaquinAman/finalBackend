using System.Net;

namespace BakeryFinal.Exceptions
{
    public class BakeryOfficeMaxOutCapacityException
    {
        public HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

        public string ErrorMessage => "Capacity of Bakery Office maxed out!";

    }
}
