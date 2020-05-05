using System;
using System.Net.Http;
using System.Web.Http.Routing;
using TreinaWeb.WebApi.Api.DTOs;
using TreinaWeb.WebApi.Api.HATEOAS.ResourceBuilders.Interfaces;

namespace TreinaWeb.WebApi.Api.HATEOAS.ResourceBuilders.Impl
{
    public class AlunoDTOResourceBuilder : IResourceBuilder
    {
        public void BuildResource(object resource, HttpRequestMessage request)
        {
            AlunoDTO dto = resource as AlunoDTO;
            if (dto == null)
            {
                throw new ArgumentException($"Era esperado um AlunoDTO, porém, foi enviado um {resource.GetType().Name}");
            }
            UrlHelper urlHelper = new UrlHelper(request);
            string alunoDTORoute = urlHelper.Link("DefaultApi", new { controller = "Alunos", id = dto.ID });
            dto.Links.Add(new RestLink
            {
                Rel = "self",
                Href = alunoDTORoute

            });
            dto.Links.Add(new RestLink
            {
                Rel = "edit",
                Href = alunoDTORoute
            });
            dto.Links.Add(new RestLink
            {
                Rel = "delete",
                Href = alunoDTORoute
            });
        }
    }
}