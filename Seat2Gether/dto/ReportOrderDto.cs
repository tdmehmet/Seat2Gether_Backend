using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class ReportOrderDto
    {
        public string OrderNumber { get; set; }
        public string MinBBNR { get; set; }
        public string MaxBBNR { get; set; }
        public string Comment { get; set; }
        public Nullable<Int32> StatusID { get; set; }
    }
}