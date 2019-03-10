using LinqToLdap;
using log4net;
using Microsoft.AspNet.Identity.EntityFramework;
using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.Utils;
using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;

namespace Seat2Gether.Repositories
{
    public class LDAPRepository
    {
        LdapConfiguration config;
        LDAPUtil ldapUtil;
        private static readonly ILog log = LogManager.GetLogger(typeof(LDAPRepository));

        public LDAPRepository()
        {
            ldapUtil = new LDAPUtil();
            config = ldapUtil.getLDAPConfiguration();
        }

        /**
        * Gets All Users with the given department name
        **/
        public List<LDAPUser> FindLdapUsersByDepartmentId(string department)
        {
            List<LDAPUser> userList = ldapUtil.getLDAPContext(config).Query<LDAPUser>().Where(ldapUser => ldapUser.Department.Contains(department)).ToList();
            return userList;            
        }

        /**
        * Gets All Users with the starting username parameter
        **/
        public List<LDAPUser> FindLdapUsersStartsWithUserName(string userName)
        {
            List<LDAPUser> userList = ldapUtil.getLDAPContext(config).Query<LDAPUser>().Where(ldapUser => ldapUser.UserPrincipalName.StartsWith(userName)).ToList();
            return userList;
        }

        public LDAPUser FindLdapUserByUserName(string userName)
        {
            LDAPUser user = null;
            try
            {
                user = ldapUtil.getLDAPContext(config).Query<LDAPUser>().Where(ldapUser => ldapUser.UserId.ToUpper().Equals(userName.ToUpper())).First();
            }catch( Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "LDAPRepository", "FindLdapUserByUserName", E);
            }
            return user;
        }

        public List<LDAPUser> FindLdapUsersByOrganizationalDNPart(string organizationalDNPart)
        {
            log.Info("LDAP REPOSITORY ORGANIZATIONAL DN PART : " + organizationalDNPart);
            List<LDAPUser> userList = ldapUtil.getLDAPContext(config).Query<LDAPUser>().Where(ldapUser => ldapUser.DistinguishedName.Contains(organizationalDNPart)).ToList();
            log.Info("TOTAL USER COUNT : " + userList.Count);
            return userList;
        }

        public List<LDAPUser> FindLdapUsersByManagerDN(string managerDN)
        {
            
            List<LDAPUser> userList = ldapUtil.getLDAPContext(config)
                .Query<LDAPUser>()
                .Where(ldapUser => ldapUser.Manager.Equals(managerDN))
                .ToList();
            return userList;
        }

        public Boolean AuthenticateUserOnLdap(string username, string password, string domain)
        {
            config.ConnectionFactory.GetConnection().Bind(new NetworkCredential(username, password, domain));
            return true;
        }


    }
}