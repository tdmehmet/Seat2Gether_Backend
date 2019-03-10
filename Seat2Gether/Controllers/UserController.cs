using log4net;
using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using Seat2Gether.Utils;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
   [RoutePrefix("api/User")]
   public class UserController : BaseController
   {
      private UserService UserService;
      private LDAPService ldapService;
      private LDAPUtil ldapUtil;

      public UserController()
      {
         UserService = new UserService();
         ldapService = new LDAPService();
         ldapUtil = new LDAPUtil();
      }

      [Route("findUserByUserName/{userName}")]
      [HttpPost]
      [Authorize]
      public IHttpActionResult FindUserByUserName(string UserName)
      {
         IHttpActionResult result = null;
         UserDto userDto = null;
         try
         {
            userDto = UserService.FindUserByUserName(UserName);
            if (!(Environment.MachineName.ToUpper().Contains("DEV") ||
            Environment.MachineName.ToUpper().Contains("KVMOB5C1SH3") ||
            Environment.MachineName.ToUpper().Contains("AHMET-EV") ||
            Environment.MachineName.ToUpper().Contains("MGN7PR8")))
            {
               if (userDto == null)
               {
                  userDto = ldapService.FindLDAPUserByUserName(UserName);
               }
            }
            result = Ok(userDto);
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "UserController", "FindUserByUserName", E);
         }
         return result;
      }

      [Route("findUsersStartsWithUserName/{userName}")]
      [HttpPost]
      [Authorize]
      public IHttpActionResult FindUsersStartsWithUserName(string userName)
      {
         IHttpActionResult result = null;
         try
         {

            if (!(Environment.MachineName.ToUpper().Contains("DEV") ||
            Environment.MachineName.ToUpper().Contains("KVMOB5C1SH3") ||
            Environment.MachineName.ToUpper().Contains("AHMET-EV") ||
            Environment.MachineName.ToUpper().Contains("MGN7PR8")))
            {
               result = Ok(ldapService.FindLdapUsersStartsWithUserName(userName));
            }
            else
            {
               result = Ok(UserService.FindUsersStartsWithUserName(userName));
            }

         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "UserController", "FindUsersStartsWithUserName", E);
         }
         return result;
      }



      [Route("findUserById/{id}")]
      [HttpPost]
      [Authorize]
      public IHttpActionResult FindUserById(string id)
      {

         IHttpActionResult result = null;
         try
         {
            result = Ok(UserService.FindUserById(id));
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "UserController", "FindUserById", E);
         }
         return result;
      }

      [Route("findUsersByManager/{userName}")]
      [HttpPost]
      [Authorize]
      public IHttpActionResult FindUsersByManager(string userName)
      {
         IHttpActionResult result = null;
         try
         {
            if (!(Environment.MachineName.ToUpper().Contains("DEV") ||
            Environment.MachineName.ToUpper().Contains("KVMOB5C1SH3") ||
            Environment.MachineName.ToUpper().Contains("AHMET-EV") ||
            Environment.MachineName.ToUpper().Contains("MGN7PR8")))
            {
               result = Ok(ldapService.FindLdapUsersByManager(userName));
            }
            else
            {
               result = Ok(UserService.FindUsers());
            }
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "UserController", "FindUsersByManager", E);
         }
         return result;
      }

      [Route("deleteUser")]
      [HttpDelete]
      [Authorize]
      public IHttpActionResult DeleteUser(User user)
      {
         try
         {
            UserService.DeleteUser(user);
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "UserController", "DeleteUser", E);
         }

         return Ok("User Successfully Deleted");
      }

      [Route("addUser")]
      [HttpPut]
      [Authorize]
      public IHttpActionResult AddUser(User user)
      {
         try
         {
            UserService.AddUser(user);
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "UserController", "AddUser", E);
         }

         return Ok("User Successfully Created");
      }

      [Route("addUserWithRoles")]
      [HttpPost]
      [Authorize]
      public IHttpActionResult AddUserWithRoles(UserDto user)
      {
         try
         {
            UserService.AddUserWithRoles(user);
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "UserController", "AddUser", E);
         }

         return Ok("User Successfully Created");
      }


      [Route("findUsersByUserBody/{manager}")]
      [HttpPost]
      [Authorize]
      public IHttpActionResult FindUsersByUserBody(string manager, UserDto user)
      {

         IHttpActionResult result = null;
         try
         {
            if (!(Environment.MachineName.ToUpper().Contains("DEV") ||
        Environment.MachineName.ToUpper().Contains("KVMOB5C1SH3") ||
        Environment.MachineName.ToUpper().Contains("AHMET-EV") ||
        Environment.MachineName.ToUpper().Contains("MGN7PR8")))
            {
               result = Ok(ldapService.FindLdapUsersByUserBodyAndManager(user, manager));
            }
            else
            {
               result = Ok(UserService.FindUsersByUserBody(user));
            }
         }
         catch (Exception E)
         {
            throw new Seat2GetherExceptionWithCode("1", "UserController", "FindUsersByUserBody", E);
         }
         return result;
      }

   }
}