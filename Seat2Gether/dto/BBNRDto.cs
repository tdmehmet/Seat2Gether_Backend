using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class BBNRDto
    {

        public string BBNRID { get; set; }
        public string  OrderID { get; set; }
        public int NumberOfLeft { get; set; }
        public int NumberOfRight { get; set; }
        public int NumberOfBack { get; set; }
        public int Count_ClubEdge { get; set; }
        public string ArmChairType { get; set; }
        public DateTime ToBe_Date { get; set; }
        public int LfdnrStatus { get; set; }
        public string CountryCode { get; set; }
        public string Customer { get; set; }
        public string ContactSales { get; set; }
        public string ContactAZ { get; set; }
        public string EUGuidelines { get; set; }
        public string Decrease { get; set; }
        public string BBNRMax { get; set; }
        public string BBNRMin { get; set; }
        public string BBNRType { get; set; }
        public string Location { get; set; }

    }
}