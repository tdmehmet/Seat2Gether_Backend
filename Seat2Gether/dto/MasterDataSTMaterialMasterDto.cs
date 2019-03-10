using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.dto
{
    public class MasterDataSTMaterialMasterDto
    {
        public string PartNumber { get; set; }
        public string Designations { get; set; }
        public int LfdNrCharacteristic { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created_On { get; set; }
        public string AlteredFrom { get; set; }
        public Nullable<DateTime> ChangedOn { get; set; }
        public int Area { get; set; }
        public string DesignationReport { get; set; }
        public bool IssueLabel { get; set; }
        public int ColumnReportSpecialSeat { get; set; }
        public string IssueReport { get; set; }
        public int LineReportCircus { get; set; }
        public string IssueReportCircus { get; set; }
        public int ColumnSSFNS { get; set; }
        public string IssueSSFNS { get; set; }
        public int ColumnSSFS { get; set; }
        public string IssueSSFS { get; set; }
        public string LabelText { get; set; }
        public string UGR { get; set; }
        public bool KSW { get; set; }



    }
}