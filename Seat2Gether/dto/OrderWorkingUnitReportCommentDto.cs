using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Seat2Gether.dto
{
    
    public class OrderWorkingUnitReportCommentDto
    {
        
        public string OrderID { get; set; }

        public int CommentID { get; set; }

        public int WorkingUnitID { get; set; }

        public WorkingUnitDto WorkingUnit { get; set; }
        
        public ReportCommentDto ReportComment { get; set; }

    }
}