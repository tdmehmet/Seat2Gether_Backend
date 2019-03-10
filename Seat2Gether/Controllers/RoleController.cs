using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/Role")]
    public class RoleController : BaseController
    {
        private RoleService RoleService = null;

        public RoleController()
        {
            RoleService = new RoleService();
        }

        [Route("findRoles")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindRoles()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(RoleService.FindRoles());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "RoleController", "FindRoles", E);
            }
            return result;
        }


        [Route("findRoleById/{id}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindRoleById(string id)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(RoleService.FindRoleById(id));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "RoleController", "findRoleById", E);
            }
            return result;
        }

        [Route("addRole")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddRole(Role role)
        {
            try
            {
                RoleService.AddRole(role);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "RoleController", "addRole", E);
            }
            
            return Ok("Role Successfully Created");

        }

        [Route("deleteRole")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteRole(Role role)
        {
            try
            {
                RoleService.DeleteRole(role);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "RoleController", "deleteRole", E);
            }

            return Ok("Role Successfully Deleted");
        }
    }
}

    