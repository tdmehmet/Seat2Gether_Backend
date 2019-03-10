using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExVehicleMaterialDto
    {
        public int Id { get; set; }
        [Required]
        public string VehicleBBNumber { get; set; }
        [Required]
        public string MaterialName { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required]
        public string StationNumber { get; set; }
    }


}
