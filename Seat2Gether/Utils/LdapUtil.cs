using LinqToLdap;
using LinqToLdap.Mapping;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.DirectoryServices.Protocols;
using System.Net;

namespace Seat2Gether.Utils
{
    

    public class LDAPUtil
    {
        private GeneralParamService generalParamService;

        public LDAPUtil()
        {
            generalParamService = new GeneralParamService();
        }

        public GeneralParamDto getLdapHost()
        {
            return generalParamService.findGeneralParamByName("com.mercedes.ldap.host");
        }

        public GeneralParamDto getLdapDomain()
        {
            return generalParamService.findGeneralParamByName("com.mercedes.ldap.domain");
        }

        public GeneralParamDto getNamingContext()
        {
            return generalParamService.findGeneralParamByName("com.mercedes.ldap.namingcontext");
        }

        public GeneralParamDto getLdapPort()
        {
            return generalParamService.findGeneralParamByName("com.mercedes.ldap.port");
        }

        public GeneralParamDto getLdapBusDepartment()
        {
            return generalParamService.findGeneralParamByName("com.mercedes.ldap.busdepartment");
        }

        public LdapConfiguration getLDAPConfiguration()
        {

            LdapConfiguration config = new LdapConfiguration().MaxPageSizeIs(1000);

            //add mapping
           // config.AddMapping(new AttributeClassMap<LDAPUser>());
            //configure connecting to the directory
            config.ConfigureFactory(getLdapHost().Value1)
                .AuthenticateBy(AuthType.Negotiate)
                .AuthenticateAs(CredentialCache.DefaultNetworkCredentials)
                .ProtocolVersion(3)
                .UsePort(Int32.Parse(getLdapPort().Value1));

            //store the configuration
            //alternately you can register it with your IoC container of choice.
            //config.UseStaticStorage();
            return config;
        }

        public DirectoryContext getLDAPContext(LdapConfiguration config)
        {
            return new DirectoryContext(config);
        }
    }
}