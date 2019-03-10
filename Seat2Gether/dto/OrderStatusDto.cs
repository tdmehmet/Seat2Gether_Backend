using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class OrderStatusDto
    {
        public decimal Id { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<Int32> StatusID { get; set; }
    }
}