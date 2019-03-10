using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class SearchBBNR
    {
        public string BBNRID { get; set; }
        public string OrderID { get; set; }
        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set; }
    }
}