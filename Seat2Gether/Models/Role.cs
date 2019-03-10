using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{
    [Table("Tb_Roles")]
    public class Role : IdentityRole
    {
        public Role()
        {
            this.RoleMenus = new HashSet<RoleMenu>();
        }

        public ICollection<RoleMenu> RoleMenus { get; set; }
    }
}