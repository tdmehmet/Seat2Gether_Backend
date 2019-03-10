using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/Menu")]
    public class MenuController : BaseController
    {
        private MenuService MenuService = null;

        public MenuController()
        {
            MenuService = new MenuService();
        }

        [Route("getUserMenu/{userName}/{language}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult GetUserMenu(string userName, string language)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MenuService.GetUserMenu(userName, language));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MenuController", "getUserMenu", E);
            }
            return result;
        }

    }
}