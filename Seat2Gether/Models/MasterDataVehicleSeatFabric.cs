using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("dbo.Tb_VehicleSeatFabric")]
    public class MasterDataVehicleSeatFabric
    {
        [Display(Name = "Id")]
        [Column("Id", Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Display(Name = "SittingArea")]
        [Column("SittingArea")]
        public string SittingArea { get; set; }

        [Display(Name = "SideArea")]
        [Column("SideArea")]
        public string SideArea { get; set; }

        [Display(Name = "BellowsArea")]
        [Column("BellowsArea")]
        public string BellowsArea { get; set; }

        [Display(Name = "BeltArea")]
        [Column("BeltArea")]
        public string BeltArea { get; set; }

        [Display(Name = "BackArea")]
        [Column("BackArea")]
        public string BackArea { get; set; }

        [Display(Name = "Rib")]
        [Column("Rib")]
        public string Rib { get; set; }

        [Display(Name = "HeaderStatic")]
        [Column("HeaderStatic")]
        public string HeaderStatic { get; set; }

        [Display(Name = "HeaderDynamic")]
        [Column("HeaderDynamic")]
        public string HeaderDynamic { get; set; }

        [Display(Name = "HeaderFastenerType")]
        [Column("HeaderFastenerType")]
        public Nullable<decimal> HeaderFastenerType { get; set; }

        [Display(Name = "VehicleBBNumber")]
        [Column("VehicleBBNumber")]
        public string VehicleBBNumber { get; set; }

        [Display(Name = "VehicleId")]
        [Column("VehicleId")]
        public decimal VehicleId { get; set; }
    }
}