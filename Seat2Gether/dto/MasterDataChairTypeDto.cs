using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataChairTypeDto
    {
        public int LfdnrChairType { get; set; }
        public string Chairtype { get; set; }
        public string Classification { get; set; }
        public double SetupTime { get; set; }
        public bool Active { get; set; }
        public bool JanzList { get; set; }
        public string OutsideCompany { get; set; }
        public string Feedback { get; set; }
        public double ReferenceTime { get; set; }
        public double PresetTimeReferenceSlot { get; set; }
        public string Group { get; set; }
        public bool UpholsteryLine { get; set; }
        public string TBSeatFrame { get; set; }
        public bool Colloquial { get; set; }
        public double FactorForNumberCalculation { get; set; }
    }
}