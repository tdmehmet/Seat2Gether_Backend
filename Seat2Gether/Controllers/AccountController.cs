using Seat2Gether.Models;
using Seat2Gether.Repositories;
using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;
using Seat2Gether.Exceptions;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : BaseController
    {
        private AccountRepository Repo = null;

        public AccountController()
        {
            try
            {
                Repo = new AccountRepository();
            } catch(Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "AccountController", "Constructor", E);
            }
        }

        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(User userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            IdentityResult result = null;
            try
            {
                result = await Repo.RegisterUser (userModel); 
            }
            catch (Exception e)
            {
                throw e;
            }
            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }
            return Ok();
        }

        [AllowAnonymous]
        [Route("RegisterUsers")]
        public async Task<IHttpActionResult> RegisterUsers(List<User> userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            IdentityResult result = null;
            try
            {
                
                foreach(User user in userModel) { 
                    await Repo.RegisterUser(user);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }
            return Ok();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Repo.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }
            return null;
        }
    }
}
