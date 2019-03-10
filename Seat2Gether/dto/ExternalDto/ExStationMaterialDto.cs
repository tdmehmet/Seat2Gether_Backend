using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExStationMaterialDto
    {
        [Required]
        public string StationNumber { get; set; }
        [Required]
        public string StationName { get; set; }
        [Required]
        public List<ExMaterialDto> MaterialList { get; set; }
    }
}