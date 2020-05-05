using Newtonsoft.Json.Serialization;
using System.Web.Http;
using TreinaWeb.WebApi.Api.Filters;
using TreinaWeb.WebApi.Api.Formatters;

namespace TreinaWeb.WebApi.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var jsonFormatter = config.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings = new Newtonsoft.Json.JsonSerializerSettings
            {

                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            };
            config.Formatters.Add(new CsvMediaTypeFormatter());

            //var xmlFormatter = config.Formatters.XmlFormatter;
            //config.Formatters.Remove(xmlFormatter);

            config.Filters.Add(new FillResponseWithHATEOASAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
