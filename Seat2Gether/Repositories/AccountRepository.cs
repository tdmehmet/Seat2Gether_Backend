using Seat2Gether.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;
using Seat2Gether.Utils;
using System.Collections.Generic;
using Seat2Gether.Exceptions;

namespace Seat2Gether.Repositories
{
    public class AccountRepository : IDisposable
    {
        private Seat2GetherDBContext DBContext;
        private UserManager<IdentityUser> UserManager;
        private LDAPRepository LdapRepository;
        private LDAPUtil ldapUtil;
        
        public AccountRepository()
        {
            DBContext = new Seat2GetherDBContext();
            UserManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(DBContext));
            LdapRepository = new LDAPRepository();
            ldapUtil = new LDAPUtil();
        } 
        /**
         * Registers Users with the given userModel 
        **/
        public async Task<IdentityResult> RegisterUser(User userModel)
        {
            User user = new User();
            
            user.UserName = userModel.UserName.ToString();
            user.DateCreated = DateTime.Now;
            user.Activated = true;
            user.Email = userModel.Email;
            user.PhoneNumber = userModel.PhoneNumber;
            user.PersonnelName = userModel.PersonnelName.ToString();
            user.PersonnelSurname = userModel.PersonnelSurname.ToString();
            user.Password = userModel.Password;
            user.ConfirmPassword = userModel.ConfirmPassword;
            
            var result = await UserManager.CreateAsync(user, userModel.Password);
            return result;
        }

        /**
         * Finds user with corresponded userName and password
        **/
        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = null;
            try
            {
                user = await UserManager.FindByNameAsync(userName);
            }catch(Exception E)
            {
                // Do nothing to check user
            }
            if (!(Environment.MachineName.ToUpper().Contains("DEV") ||
            Environment.MachineName.ToUpper().Contains("KVMOB5C1SH3") ||
            Environment.MachineName.ToUpper().Contains("AHMET-EV") ||
            Environment.MachineName.ToUpper().Contains("MGN7PR8")))
            {
            try
                {
                    LdapRepository.AuthenticateUserOnLdap(userName, password, ldapUtil.getLdapDomain().Value1);
                }catch (Exception E)
                {
            
                    throw new Seat2GetherExceptionWithCode("1", "AccountRepository", "FindUser",
                      new Exception("message:The user name or password is incorrect. " +
                                      ";exceptionMessage:invalid_grant" +
                                      ";exceptionType:GrantResourceOwnerCredentials" +
                                      ";stackTrace:invalid_grant, The user name or password is incorrect."));
                }
                if (user == null)
                {
                    LDAPUser ldapUser = null;
                    ldapUser = LdapRepository.FindLdapUserByUserName(userName);
                    User userToSave = ldapUser.CreateMapped<LDAPUser, User>();
                    userToSave.UserName = userName;
                    userToSave.Password = Constraints.DefaultDBPassword;
                    userToSave.ConfirmPassword = Constraints.DefaultDBPassword;
                    userToSave.DateCreated = DateTime.Now;
                    List<LDAPUser> personnelList = null;
                    try
                    {
                        personnelList = LdapRepository.FindLdapUsersByManagerDN(ldapUser.DistinguishedName);
                    }catch(Exception E )
                    {
                        throw new Seat2GetherExceptionWithCode("1", "AccountRepository", "FindUser", E);
                    }
                    if (personnelList.Count > 0)
                    {
                        UserRole userRole = new UserRole();
                        userRole.RoleId = "1";
                        userRole.UserId = userToSave.Id;
                        userToSave.Roles.Add(userRole);
                    }
                    try
                    {
                        await UserManager.CreateAsync(userToSave, Constraints.DefaultDBPassword);
                    }catch(Exception E)
                    {
                        throw new Seat2GetherExceptionWithCode("1", "AccountRepository", "FindUser", E);
                    }
                }
            }
            try
            {
                user = await UserManager.FindByNameAsync(userName);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "AccountRepository", "FindUser", E);
            }
            if(user == null)
            {
               
                throw new Seat2GetherExceptionWithCode("1", "AccountRepository", "FindUser", 
                    new Exception("message:The user name or password is incorrect. " +
                                    ";exceptionMessage:invalid_grant" +
                                    ";exceptionType:GrantResourceOwnerCredentials" +
                                    ";stackTrace:invalid_grant, The user name or password is incorrect."));
            }
            return user;
    }

        public void Dispose()
        {
            DBContext.Dispose();
            UserManager.Dispose();
        }
     }

}