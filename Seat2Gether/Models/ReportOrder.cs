using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.Vw_EditOrder")]
    public class ReportOrder
    {
        [Display(Name = "OrderNumber")]
        [Column("OrderNumber")]
        [Key]
        public string OrderNumber { get; set; }

        [Display(Name = "MinBBNR")]
        [Column("MinBBNR")]
        public string MinBBNR { get; set; }

        [Display(Name = "MaxBBNR")]
        [Column("MaxBBNR")]
        public string MaxBBNR { get; set; }

        [Display(Name = "Comment")]
        [Column("Comment")]
        public string Comment { get; set; }

        [Display(Name = "StatusID")]
        [Column("StatusID")]
        public Nullable<Int32> StatusID { get; set; }
    }


}