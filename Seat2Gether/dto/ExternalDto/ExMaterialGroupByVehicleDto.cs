using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExMaterialGroupByVehicleDto
    {
        public string BBNumber { get; set; }
        public bool Created { get; set; }
        public List<ExMaterialDto> Materials { get; set; }
    }
}