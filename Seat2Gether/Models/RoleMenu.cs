using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("Tb_RoleMenus")]
    public class RoleMenu
    {
        [Display(Name = "RoleId")]
        [Column("RoleId", Order = 0)]
        [Required]
        [MaxLength(128)]
        [Key]
        public virtual string RoleId { get; set; }

        [Display(Name = "MenuId")]
        [Column("MenuId", Order = 1)]
        [Required]
        [MaxLength(128)]
        [Key]
        public virtual string MenuId { get; set; }
    }
}