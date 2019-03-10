using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("dbo.T_BBNR_Report")]
    public class ReportLog
    {

        [Display(Name = "BBNr")]
        [Column("BBNr", Order = 0)]
        [Key]
        public string BBNR { get; set; }

        [Display(Name = "Deck")]
        [Column("Deck", Order = 1)]
        [Key]
        public string Deck { get; set; }

        [Display(Name = "Report")]
        [Column("Report", Order = 2)]
        [Key]
        public string ReportName { get; set; }

        [Display(Name = "gedruckt_am")]
        [Column("gedruckt_am", Order = 3)]
        [Key]
        public DateTime ReportDate { get; set; }

        [Display(Name = "gedruckt_von")]
        [Column("gedruckt_von", Order = 4)]
        [Key]
        public string ReportUser { get; set; }

    }
}
      
  