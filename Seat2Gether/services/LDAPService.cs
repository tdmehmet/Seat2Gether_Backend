
using log4net;
using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;

namespace Seat2Gether.services
{

    public class LDAPService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LDAPService));
        private LDAPRepository ldapRepository = null;

        public LDAPService()
        {
            ldapRepository = new LDAPRepository();
        }

        public List<UserDto> FindLDAPUsersByDepartmentId(string departmentId)
        {
            List<LDAPUser> ldapUserList = ldapRepository.FindLdapUsersByDepartmentId(departmentId);
            return ldapUserList.CreateMappedList<LDAPUser, UserDto>();
        }

        public List<UserDto> FindLdapUsersStartsWithUserName(string userName)
        {
            List<LDAPUser> ldapUserList = ldapRepository.FindLdapUsersStartsWithUserName(userName);
            return ldapUserList.CreateMappedList<LDAPUser, UserDto>();
        }

        public UserDto FindLDAPUserByUserName(string userName)
        {
            LDAPUser ldapUser = ldapRepository.FindLdapUserByUserName(userName);
            return ldapUser.CreateMapped<LDAPUser, UserDto>();
        }

        public void AuthenticateUserOnLdap(string username, string password, string domain)
        {
            ldapRepository.AuthenticateUserOnLdap(username, password, domain);
        }

        public List<UserDto> FindLdapUsersByManager(string managerUserName)
        {
            
            LDAPUser ldapUser = ldapRepository.FindLdapUserByUserName(managerUserName);
            List<LDAPUser> ldapUserList = null;
            log.Info("USER NAME : " + managerUserName);
            if (managerUserName.ToUpper().Equals("HJANKER") || managerUserName.ToUpper().Equals("MEHDEDE") || managerUserName.ToLower().Equals("ocelikk")
                || managerUserName.ToLower().Equals("okaraki") || managerUserName.ToLower().Equals("eulusal"))
            {

                ldapUserList = ldapRepository.FindLdapUsersByManagerDN(managerUserName);
                ldapUser = ldapRepository.FindLdapUserByUserName("rgulde");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapUser.DistinguishedName));
                ldapUser = ldapRepository.FindLdapUserByUserName("fkilinc");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapUser.DistinguishedName));
                ldapUser = ldapRepository.FindLdapUserByUserName("bsertka");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapUser.DistinguishedName));
                ldapUser = ldapRepository.FindLdapUserByUserName("eulusal");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapUser.DistinguishedName));
                ldapUser = ldapRepository.FindLdapUserByUserName("ncevrim");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapUser.DistinguishedName));
            }
            else { 
                ldapUserList = ldapRepository.FindLdapUsersByManagerDN(ldapUser.DistinguishedName);
            }
            return ldapUserList.CreateMappedList<LDAPUser, UserDto>();
        }

        public List<UserDto> FindLdapUsersByUserBodyAndManager(UserDto userDto, string manager)
        {
            LDAPUser ldapManagerUser = ldapRepository.FindLdapUserByUserName(manager);
            List<LDAPUser> ldapUserList = null;
            log.Info("Manager : " + manager);
            if (manager.ToUpper().Equals("HJANKER") || manager.ToUpper().Equals("MEHDEDE") || manager.ToLower().Equals("ocelikk")
                || manager.ToLower().Equals("okaraki") || manager.ToLower().Equals("eulusal"))
            {
                ldapUserList = ldapRepository.FindLdapUsersByManagerDN(manager);
                ldapManagerUser = ldapRepository.FindLdapUserByUserName("rgulde");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapManagerUser.DistinguishedName));
                ldapManagerUser = ldapRepository.FindLdapUserByUserName("fkilinc");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapManagerUser.DistinguishedName));
                ldapManagerUser = ldapRepository.FindLdapUserByUserName("bsertka");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapManagerUser.DistinguishedName));
                ldapManagerUser = ldapRepository.FindLdapUserByUserName("eulusal");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapManagerUser.DistinguishedName));
                ldapManagerUser = ldapRepository.FindLdapUserByUserName("ncevrim");
                ldapUserList.AddRange(ldapRepository.FindLdapUsersByManagerDN(ldapManagerUser.DistinguishedName));
            }
            else
            {
                ldapUserList = ldapRepository.FindLdapUsersByManagerDN(ldapManagerUser.DistinguishedName);
            }


            List<LDAPUser> tmpUsers = new List<LDAPUser>();
            
            User userBody = userDto.CreateMapped<UserDto, User>();
            if (userBody != null)
            {
                foreach (LDAPUser user in ldapUserList)
                {
                    if ((user.UserName.ToUpper().Contains(userBody.UserName.ToUpper()) || userBody.UserName == null || userBody.UserName.Equals("")) &&
                        (user.PersonnelName.ToUpper().Contains(userBody.PersonnelName.ToUpper()) || userBody.PersonnelName == null || userBody.PersonnelName.Equals("")) &&
                        (user.PersonnelSurName.ToUpper().Contains(userBody.PersonnelSurname.ToUpper()) || userBody.PersonnelSurname == null || userBody.PersonnelSurname.Equals("")))
                    {
                        tmpUsers.Add(user);
                    }
                }
            }
            return tmpUsers.CreateMappedList<LDAPUser, UserDto>();
        }

    }
}