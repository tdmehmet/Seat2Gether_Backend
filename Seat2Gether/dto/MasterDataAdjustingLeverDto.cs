using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataAdjustingLeverDto
    {
        public string PartNumber { get; set; }
        public int NumberOfBlocking { get; set; }
        public string Designation { get; set; }
        public string Page { get; set; }
        public string Designations { get; set; }
        

       /* public AdjustingLeverDto(string PartNumber, int NumberOfBlocking, string Designation,
            string Page, string Designations )
        {
            this.PartNumber = PartNumber;
            this.NumberOfBlocking = NumberOfBlocking;
            this.Designations = Designations;
            this.Designation = Designation;
            this.Page = Page;
        }*/

    }
}