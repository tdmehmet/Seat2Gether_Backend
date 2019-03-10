using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.A_BBNR_KSW")]
    public class BBNRKSW
    {
        [Display(Name = "BBNR")]
        [Column("BBNr",Order=0)]
        [Key]
        public string BBNRID { get; set; }

        [Key]
        [Display(Name = "AuftragsNr")]
        [Column("AuftragsNr",Order =1)]
       
        public string OrderID { get; set; }

        [Display(Name = "KSW_Mitteilung")]
        [Column("KSW_Mitteilung")]
        public string KSWCommunication { get; set; }

        [Display(Name = "Zuschnitt")]
        [Column("Zuschnitt")]
        public bool Cut { get; set; }

        [Display(Name = "Näherei")]
        [Column("Näherei")]
        public bool Sewing { get; set; }

        [Display(Name = "Montage")]
        [Column("Montage")]
        public bool Assembly { get; set; }
    }
}

     