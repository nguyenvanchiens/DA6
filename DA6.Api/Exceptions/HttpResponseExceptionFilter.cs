using DA6.Core.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DA6.Api.Exceptions
{
    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order => int.MaxValue - 10;

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is HttpResponseException httpResponseException)
            {
                var result = new
                {
                    devMsg = Properties.Resources.BadRequest,
                    userMgs = Properties.Resources.ExceptionError,
                    data = httpResponseException.Value,
                    status = (int)StatusCodeRespon.BadRequest,
                    moreInfo = ""
                };
                context.Result = new ObjectResult(result)
                {
                    StatusCode = (int)StatusCodeRespon.BadRequest
                };

                context.ExceptionHandled = true;
            }
            else if (context.Exception != null)
            {
                var result = new
                {
                    devMsg = Properties.Resources.Internal_Server_Error,
                    userMgs = Properties.Resources.ExceptionError,
                    data = DBNull.Value,
                    status = (int)StatusCodeRespon.ErrorServer,
                    moreInfo = ""
                };
                context.Result = new ObjectResult(result)
                {
                    StatusCode = (int)StatusCodeRespon.ErrorServer,
                };

                context.ExceptionHandled = true;
            }
        }
    }
}
