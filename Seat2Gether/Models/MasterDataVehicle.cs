using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{


    [Table("dbo.Tb_Vehicle")]
    public class MasterDataVehicle
    {
        [Display(Name = "Id")]
        [Column("Id", Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Display(Name = "BBNumber")]
        [Column("BBNumber")]
        public string BBNumber { get; set; }

        [Display(Name = "TypeId")]
        [Column("TypeId")]
        public decimal TypeId { get; set; }

        [Display(Name = "Country")]
        [Column("Country")]
        public string Country { get; set; }

        [Display(Name = "ModelId")]
        [Column("ModelId")]
        public decimal ModelId { get; set; }

    }
}