using Seat2Gether.Exceptions;
using Seat2Gether.services;
using Seat2Gether.Utils;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/LDAP")]
    public class LDAPController : BaseController
    {
        private LDAPService LdapService;
        private LDAPUtil ldapUtil;

        public LDAPController()
        {
            LdapService = new LDAPService();
            ldapUtil = new LDAPUtil();
        }

        [Route("findLDAPUsersByBusDepartment")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindLDAPUsersByBusDepartment()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(LdapService.FindLDAPUsersByDepartmentId(ldapUtil.getLdapBusDepartment().Value1));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "LDAPController", "findLDAPUsersByBusDepartment", E);
            }

            return result;
        }

        [Route("findLDAPUserById/{userName}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindUserByUserName(string userName)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(LdapService.FindLDAPUserByUserName(userName));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "LDAPController", "FindUserByUserName", E);
            }

            return result;
        }
    }
}