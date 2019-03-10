using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    
        [Table("dbo.Tb_VehicleSeatMainInfo")]
        public class MasterDataVehicleSeatMainInfo
    {
            [Display(Name = "Id")]
            [Column("Id", Order = 0)]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public decimal ID { get; set; }

            [Display(Name = "ImageURL")]
            [Column("ImageURL")]
            public string ImageURL { get; set; }

            [Display(Name = "SeatType")]
            [Column("SeatType")]
            public decimal SeatType { get; set; }

            [Display(Name = "Passenger")]
            [Column("Passenger")]
            public decimal Passenger { get; set; }

            [Display(Name = "DriverSeatCount")]
            [Column("DriverSeatCount")]
            public decimal DriverSeatCount { get; set; }

        [Display(Name = "SeatHolder")]
        [Column("SeatHolder")]
        public string SeatHolder { get; set; }

        [Display(Name = "Hostess")]
        [Column("Hostess")]
        public decimal Hostess { get; set; }

        [Display(Name = "Hostes")]
        [Column("Hostes")]
        public string Hostes { get; set; }
        [Display(Name = "VehicleBBNumber")]
        [Column("VehicleBBNumber")]
        public string VehicleBBNumber { get; set; }

        [Display(Name = "VehicleId")]
        [Column("VehicleId")]
        public decimal VehicleId { get; set; }


    }
    }
