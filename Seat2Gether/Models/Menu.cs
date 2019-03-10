#region Assembly Microsoft.AspNet.Identity.EntityFramework, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// C:\Users\mehdede\Source\Repos\MBT_Bus_Dev\backend\packages\Microsoft.AspNet.Identity.EntityFramework.2.0.1\lib\net45\Microsoft.AspNet.Identity.EntityFramework.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{
    [Table("Tb_Menus")]
    public class Menu 
    {
        public Menu()
        {
            this.RoleMenus = new HashSet<RoleMenu>();
        }

        [Display(Name = "Id")]
        [Key]
        [Column("Id")]
        [Required]
        [MaxLength(128)]
        public string Id { get; set; }

        [Display(Name = "EnglishName")]
        [Column("EnglishName")]
        [Required]
        [MaxLength(75)]
        public string EnglishName { get; set; }

        [Display(Name = "GermanName")]
        [Column("GermanName")]
        [Required]
        [MaxLength(75)]
        public string GermanName { get; set; }

        [Display(Name = "TurkishName")]
        [Column("TurkishName")]
        [Required]
        [MaxLength(75)]
        public string TurkishName { get; set; }

        [Display(Name = "Code")]
        [Column("Code")]
        [Required]
        [MaxLength(200)]
        public string Code { get; set; }

        [Display(Name = "Enabled")]
        [Column("Enabled")]
        [Required]
        public int _Enabled { get; set; }

        [NotMapped]
        public bool Enabled
        {
            get
            {
                return _Enabled != 0;
            }
            set
            {
                _Enabled = value ? 1 : 0;
            }
        }

        [Display(Name = "ProjectName")]
        [Column("ProjectName")]
        [Required]
        [MaxLength(75)]
        public string ProjectName { get; set; }

        [Display(Name = "EnglishDescription")]
        [Column("EnglishDescription")]
        [MaxLength(250)]
        public string EnglishDescription { get; set; }

        [Display(Name = "GermanDescription")]
        [Column("GermanDescription")]
        [MaxLength(250)]
        public string GermanDescription { get; set; }

        [Display(Name = "TurkishDescription")]
        [Column("TurkishDescription")]
        [MaxLength(250)]
        public string TurkishDescription { get; set; }

        [Display(Name = "Path")]
        [Column("Path")]
        [Required]
        [MaxLength(200)]
        public string Path { get; set; }

        [Display(Name = "Icon")]
        [Column("Icon")]
        [MaxLength(250)]
        public string Icon { get; set; }

        [Display(Name = "Pathmatch")]
        [Column("Pathmatch")]
        [MaxLength(250)]
        public string Pathmatch { get; set; }

        [Display(Name = "Order")]
        [Column("Order")]
        public string Order { get; set; }

        [Display(Name = "Selected")]
        [Column("Selected")]
        public int _Selected { get; set; }

        [NotMapped]
        public bool Selected
        {
            get
            {
                return _Selected != 0;
            }
            set
            {
                _Selected = value ? 1 : 0;
            }
        }

        [Display(Name = "Expanded")]
        [Column("Expanded")]
        public int _Expanded { get; set; }

        [NotMapped]
        public bool Expanded
        {
            get
            {
                return _Expanded != 0;
            }
            set
            {
                _Expanded = value ? 1 : 0;
            }
        }

        public ICollection<RoleMenu> RoleMenus { get; set; }

    }
}