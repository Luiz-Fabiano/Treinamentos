using System.Collections.Generic;

namespace TreinaWeb.WebApi.Api.HATEOAS
{
    public abstract class RestResource
    {
        public List<RestLink> Links { get; set; } = new List<RestLink>();
    }
}