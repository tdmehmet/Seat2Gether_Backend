using LinqToLdap.Mapping;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;



[DirectorySchema(NamingContext, ObjectCategory = "Person", ObjectClass = "user")]
public class LDAPUser
{

    public const string NamingContext = "DC=emea,DC=corpdir,DC=net";

    [DistinguishedName]
    public string DistinguishedName { get; set; }

    [DirectoryAttribute("c", ReadOnly = true)]
    public string CountryCode { get; set; }

    [DirectoryAttribute("cn", ReadOnly = true)]
    public string CommonName { get; set; }

    [NotMapped]
    public string PersonnelName
    {
        get
        {
            string name = "";
            if(CommonName != null && CommonName.Contains(",") && CommonName.Contains("("))
            {
                string tmpName = CommonName.Substring(CommonName.IndexOf(",") + 1).Trim();
                name = tmpName.Substring(0, tmpName.IndexOf("(")).Trim();
            }
            return name;
        }
    }

    [NotMapped]
    public string PersonnelSurName
    {
        get
        {
            string surname = "";
            if (CommonName != null && CommonName.Contains(",") && CommonName.Contains("("))
            {
                surname = (CommonName.Substring(0, CommonName.IndexOf(","))).Trim();
            }
            return surname;
        }
    }

    [DirectoryAttribute("dcxBuilding", ReadOnly = true)]
    public string Building { get; set; }

    [DirectoryAttribute("dcxHPC", ReadOnly = true)]
    public string Location { get; set; }

    [DirectoryAttribute("dcxSiteCode", ReadOnly = true)]
    public string SiteCode { get; set; }

    [DirectoryAttribute("dcxUid", ReadOnly = true)]
    public string UserId { get; set; }

   

    [DirectoryAttribute("department", ReadOnly = true)]
    public string Department { get; set; }

    [DirectoryAttribute("displayName", ReadOnly = true)]
    public string DisplayName { get; set; }

    [DirectoryAttribute("division", ReadOnly = true)]
    public string Division { get; set; }

    [DirectoryAttribute("givenName", ReadOnly = true)]
    public string GivenName { get; set; }

    [DirectoryAttribute("I", ReadOnly = true)]
    public string City { get; set; }

    [DirectoryAttribute("mail", ReadOnly = true)]
    public string Mail { get; set; }

    [NotMapped]
    public string Email
    {
        get
        {
            return Mail;
        }
    }
    
    [DirectoryAttribute("mobile", ReadOnly = true)]
    public string Mobile { get; set; }

    [NotMapped]
    public string PhoneNumber
    {
        get
        {
            return Mobile;
        }
    }

    [DirectoryAttribute("name", ReadOnly = true)]
    public string Name { get; set; }

    [DirectoryAttribute("sn", ReadOnly = true)]
    public string Surname { get; set; }

    [DirectoryAttribute("telephoneNumber", ReadOnly = true)]
    public string TelephoneNumber { get; set; }

    [DirectoryAttribute("userAccountControl", ReadOnly = true)]
    public string UserAccountControl { get; set; }

    [DirectoryAttribute("userPrincipalName", ReadOnly = true)]
    public string UserPrincipalName { get; set; }
    [NotMapped]
    public string UserName
    {
        get
        {
            
            if(UserPrincipalName != null && UserPrincipalName.Contains("@")) { 
                return UserPrincipalName.Substring(0, UserPrincipalName.IndexOf("@")).Trim();
            }
            return "";

        }
    }

    [DirectoryAttribute("whenCreated", ReadOnly = true)]
    public DateTime WhenCreated { get; set; }

    [NotMapped]
    public DateTime DateCreated
    {
        get
        {
            return WhenCreated;
        }
    }

    [NotMapped]
    public Boolean Activated
    {
        get
        {
            return true;
        }
    }

    [DirectoryAttribute("manager", ReadOnly = true)]
    public string Manager { get; set; }

    [DirectoryAttribute("sAMAccountName", ReadOnly = true)]
    public string SAMAccountName { get; set; }

    public void SetDistinguishedName()
    {
        DistinguishedName = string.Format("CN={0},{1}", CommonName, NamingContext);
    }
}