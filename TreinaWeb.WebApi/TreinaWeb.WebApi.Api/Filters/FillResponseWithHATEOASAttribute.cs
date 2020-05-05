using System.Linq;
using System.Net.Http;
using System.Web.Http.Filters;
using TreinaWeb.WebApi.Api.HATEOAS.Helpers;

namespace TreinaWeb.WebApi.Api.Filters
{
    public class FillResponseWithHATEOASAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            // application/hal+json
            if (actionExecutedContext.Response.IsSuccessStatusCode &&
                actionExecutedContext.Request.Headers.SelectMany(s => s.Value).Any(a => a.Contains("hal")))
            {
                ObjectContent responseContent = actionExecutedContext.Response.Content as ObjectContent;
                object responseValue = responseContent.Value;
                RestResourceBuilder.BuildResource(responseValue, actionExecutedContext.Request);
            }
        }
    }
}