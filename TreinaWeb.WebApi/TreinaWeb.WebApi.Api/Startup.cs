using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;
using TreinaWeb.WebApi.Api.Providers;

[assembly: OwinStartup(typeof(TreinaWeb.WebApi.Api.Startup))]

namespace TreinaWeb.WebApi.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions oAuthOptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromSeconds(50),
                Provider = new SimpleAuthServerProvider()
            };
            app.UseOAuthAuthorizationServer(oAuthOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
