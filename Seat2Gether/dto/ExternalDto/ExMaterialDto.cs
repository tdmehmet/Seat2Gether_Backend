using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExMaterialDto
    {
        public int Id { get; set; }
        public string VehicleBBNumber { get; set; }

        public string MaterialName { get; set; }

        public string MaterialNumber { get; set; }

        public double Quantity { get; set; }

        public string Unit { get; set; }

        public string StationNumber { get; set; }
        public string SubGroupId { get; set; }
        public string WarehouseNumber { get; set; }
        public string StationName { get; set; }
    }
}