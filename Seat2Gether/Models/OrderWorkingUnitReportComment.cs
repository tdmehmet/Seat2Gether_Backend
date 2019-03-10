using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.Tb_OrderWorkingUnitReportComment")]
    public class OrderWorkingUnitReportComment
    {

        [Display(Name = "OrderID")]
        [Column("OrderID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string OrderID { get; set; }

        [ForeignKey("ReportComment")]
        [Column("CommentID", Order=1)]
        [Key]
        public int CommentID{ get; set; }
        
        [ForeignKey("WorkingUnit")]
        [Column("WorkingUnitID", Order = 2)]
        [Key]
        public int WorkingUnitID { get; set; }


        public virtual WorkingUnit WorkingUnit { get; set; }
        public virtual ReportComment ReportComment { get; set; }


    }
}
