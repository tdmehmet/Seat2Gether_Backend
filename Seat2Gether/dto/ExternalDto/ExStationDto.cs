using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto.ExternalDto
{
    public class ExStationDto
    {
        [Required]
        public string StationNumber { get; set; }
        [Required]
        public string StationName { get; set; }
    }
}