using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class RoleRepository
    {
        private Seat2GetherDBContext DBContext;

        public RoleRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        /**
        * finds all roles
        **/
        public List<Role> FindRoles()
        {

            var rolesQuery = from role in DBContext.Roles
                             select role;

            List<Role> allRoles = rolesQuery.ToList();
            return allRoles;
        }

        public Role FindRoleById(String Id)
        {
            return DBContext.Roles.Find(Id);
        }

        /**
        * Add a new role 
        **/
        public void AddRole(Role role)
        {
            DBContext.Roles.Add(role);
            DBContext.SaveChanges();
        }

        /**
        * Deletes role 
        **/
        public void DeleteRole(Role role)
        {
            DBContext.Roles.Remove(role);
            DBContext.SaveChanges();
        }

    }
}