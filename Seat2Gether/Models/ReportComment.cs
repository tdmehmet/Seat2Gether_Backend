using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.Tb_ReportComment")]
    public class ReportComment
    {
        [Display(Name = "ID")]
        [Column("ID")]
        [Key]
        public Int32 ID { get; set; }

        [Display(Name = "Comment")]
        [Column("Comment")]
        public string CommentText { get; set; }

        public ICollection<OrderWorkingUnitReportComment> OrderWorkingUnitReportComments { get; set; }

    }
}