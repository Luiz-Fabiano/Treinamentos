using System.Net.Http;

namespace TreinaWeb.WebApi.Api.HATEOAS.ResourceBuilders.Interfaces
{
    interface IResourceBuilder
    {
        void BuildResource(object resource, HttpRequestMessage request);
    }
}
