using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("dbo.Tb_VehicleMaterial")]
    public class MasterDataVehicleMaterial
    {
        [Display(Name = "Id")]
        [Column("Id", Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Display(Name = "SubGroup")]
        [Column("SubGroup")]
        public decimal SubGroup { get; set; }

        [Display(Name = "VehicleBBNumber")]
        [Column("VehicleBBNumber")]
        public string VehicleBBNumber { get; set; }

        [Display(Name = "MaterialNumber")]
        [Column("MaterialNumber")]
        public string MaterialNumber { get; set; }

        [Display(Name = "Amount")]
        [Column("Amount")]
        public decimal Amount { get; set; }

        [Display(Name = "BMType")]
        [Column("BMType")]
        public string BMType { get; set; }

        [Display(Name = "OrderNumber")]
        [Column("OrderNumber")]
        public decimal OrderNumber { get; set; }

        [Display(Name = "VehicleId")]
        [Column("VehicleId")]
        public decimal VehicleId { get; set; }

        

    }
}
