using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TreinaWeb.WebApi.Api.Providers
{
    public class SimpleAuthServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new string[] { "*" });
            if (context.UserName != "treinaweb" || context.Password != "treinaweb")
            {
                context.SetError("Invalid_user_or_password", "Usuário e/ou semha incorretos.");
                return;
            }
            ClaimsIdentity identity = new ClaimsIdentity(context.Options.AuthenticationType);
            context.Validated(identity);

        }
    }
}