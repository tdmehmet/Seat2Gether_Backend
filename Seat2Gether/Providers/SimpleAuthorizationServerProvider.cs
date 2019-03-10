using Seat2Gether.Repositories;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Seat2Gether.Exceptions;

namespace Seat2Gether.Providers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            try { 
                context.Validated();
            } catch(Exception E)
            {
                throw new Seat2GetherExceptionWithCode("3", "SimpleAuthorizationServerProvider", "ValidateClientAuthentication", E);
            }
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
             
            //context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            using (AccountRepository repo = new AccountRepository())
            {
                IdentityUser user = null;
                try
                {
                    user = await repo.FindUser(context.UserName, context.Password);
                }catch(Seat2GetherExceptionWithCode e)
                {
                    context.SetError(e.statusText);
                    return;
                }
                if (user == null)
                {
                    //throw new Seat2GetherExceptionWithCode("100", "Test", "test", new Exception("TTTTEEESSSSTTT"));
                    //context.SetError("invalid_grant", "The user name or password is incorrect.");
                    context.SetError("message:The user name or password is incorrect. " +
               ";exceptionMessage:invalid_grant" +
               ";exceptionType:GrantResourceOwnerCredentials" +
               ";stackTrace:invalid_grant, The user name or password is incorrect.");
                    
                   return;
                }
            }
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);
            
        }
    }


}