using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataSTCharacteristicDto
    {
        public int LfdNrCharacteristic { get; set; }
        public string Characteristic { get; set; }
        public Int32 Sort { get; set; }
        public int LfdNrPot { get; set; }
        public bool Cut { get; set; }
        public bool Stitching { get; set; }
        public bool SpecialSeat { get; set; }
        public bool Montage { get; set; }
        public bool IssueCircus { get; set; }
        public bool MaterialRelevant { get; set; }

      
    }
}