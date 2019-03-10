using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{


    [Table("dbo.T_Auftrag")]
    public class Order
    {
        [Display(Name = "AuftragsNr")]
        [Column("AuftragsNr")]
        [Key]
        public string OrderNumber { get; set; }

        [Display(Name = "Bemerkung")]
        [Column("Bemerkung")]
        public string Comment { get; set; }

        [Display(Name = "Bemerkung_Janz")]
        [Column("Bemerkung_Janz")]
        public string CommentJanz { get; set; }

    }
}
