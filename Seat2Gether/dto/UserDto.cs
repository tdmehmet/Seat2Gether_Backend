using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class UserDto
    { 
        public string Id { get; set; }
        public string PersonnelName { get; set; }
        public string PersonnelSurname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public Boolean Activated { get; set; }
        public string DistinguishedName { get; set; }
        public List<UserRole> Roles { get; set; }
    }
}