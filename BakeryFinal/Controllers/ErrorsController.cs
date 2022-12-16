using Azure;
using BakeryFinal.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BakeryFinal.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorsController : ControllerBase
    {
        [Route("/error")]
        public ActionResult<ResponseDTO> Error()
        {
            Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

            if (exception is IServiceException serviceException)
            {
                Response.Headers.Add("Status-Code", ((int)serviceException.StatusCode).ToString());

                var responseServiceException = new ResponseDTO
                {
                    Response = serviceException.ErrorMessage
                };

                return StatusCode((int)serviceException.StatusCode, responseServiceException);
            }

            return Problem();
        }
    }

}
