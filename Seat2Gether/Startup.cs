using Seat2Gether.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using log4net;
using log4net.Config;
using Seat2Gether.Exceptions;
using Swashbuckle.Application;
using System.Net.Http;

[assembly: OwinStartup(typeof(Seat2Gether.API.Startup))]
namespace Seat2Gether.API
{
   public class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         try
         {
            XmlConfigurator.Configure();
            HttpConfiguration config = new HttpConfiguration();

            app.UseCors(CorsOptions.AllowAll);

            ConfigureOAuth(app);

            WebApiConfig.Register(config);
            SwaggerConfig.Register(config);
            app.UseWebApi(config);
            
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "Startup", "Configuration", E);
         }
      }

      public void ConfigureOAuth(IAppBuilder app)
      {
         OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
         {
            AllowInsecureHttp = true,
            TokenEndpointPath = new PathString("/token"),
            AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
            Provider = new SimpleAuthorizationServerProvider()
         };
         try
         {
            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "Startup", "ConfigureOAuth", E);
         }

      }


   }
}