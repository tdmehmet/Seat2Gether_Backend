using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExVehicleFilterDto
    {
        public string BBNumber { get; set; }
        public decimal? TypeId { get; set; }
        public decimal? CountryId { get; set; }
        public decimal? ModelId { get; set; }
       
    }
}