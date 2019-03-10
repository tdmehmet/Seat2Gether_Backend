using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class RoleService
    {
        private RoleRepository RoleRepository = null;

        public RoleService()
        {
            RoleRepository = new RoleRepository();
        }

        public List<RoleDto> FindRoles()
        {

            List<RoleDto> roleDtoList = new List<RoleDto>();
            List<Role> roleList = new List<Role>();
            roleList = RoleRepository.FindRoles();

            roleDtoList = roleList.CreateMappedList<Role, RoleDto>();
            
            return roleDtoList;
        }


        public Role FindRoleById(String Id)
        {
            return RoleRepository.FindRoleById(Id);
        }

        /// <summary>
        /// Add a new role
        /// </summary>
        /// <param name="role"></param>
        public void AddRole(Role role)
        {
            Role tmpRole = RoleRepository.FindRoleById(role.Id);
            
            if (tmpRole == null)
            {
                RoleRepository.AddRole(role);
            }
        }

        /// <summary>
        /// delete Role
        /// </summary>
        /// <param name="role"></param>
        public void DeleteRole(Role role)
        {
            Role tmpRole = RoleRepository.FindRoleById(role.Id);

            if (tmpRole != null)
            {
                RoleRepository.DeleteRole(tmpRole);
            }
        }
    }
}


    