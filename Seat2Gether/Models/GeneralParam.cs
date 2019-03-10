using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{
    [Table("Tb_GeneralParams")]
    public class GeneralParam
    {
        [Display(Name = "Id")]
        [Key]
        [Column("Id")]
        [Required]
        [MaxLength(128)]
        public string Id { get; set; }

        [Display(Name = "Name")]
        [Column("Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Value1")]
        [Column("Value1")]
        [Required]
        [MaxLength(250)]
        public string Value1 { get; set; }

        [Display(Name = "Value2")]
        [Column("Value2")]
        [Required]
        [MaxLength(250)]
        public string Value2 { get; set; }

        [Display(Name = "Value3")]
        [Column("Value3")]
        [Required]
        [MaxLength(250)]
        public string Value3 { get; set; }

        [Display(Name = "Active")]
        [Column("Active")]
        [Required]
        public int _Active { get; set; }

        [NotMapped]
        public bool Active
        {
            get
            {
                return _Active != 0;
            }
            set
            {
                _Active = value ? 1 : 0;
            }
        }

        [Display(Name = "ParamGroup")]
        [Column("ParamGroup")]
        [Required]
        [MaxLength(250)]
        public string ParamGroup { get; set; }

        [Display(Name = "CreateDate")]
        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "CreateUser")]
        [Column("CreateUser")]
        [MaxLength(50)]
        public string CreateUser { get; set; }

        [Display(Name = "UpdateDate")]
        [Column("UpdateDate")]
        public DateTime UpdateDate { get; set; }

        [Display(Name = "UpdateUser")]
        [Column("UpdateUser")]
        [MaxLength(50)]
        public string UpdateUser { get; set; }

    }
}