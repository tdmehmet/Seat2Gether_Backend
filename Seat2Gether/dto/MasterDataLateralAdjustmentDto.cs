using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataLateralAdjustmentDto
    {
        public string EB { get; set; }
        public string Designation { get; set; }
        public bool LateralAdjustmentLI { get; set; }
        public bool LateralAdjustmentRE { get; set; }
        public string Gauge { get; set; }
    }
}