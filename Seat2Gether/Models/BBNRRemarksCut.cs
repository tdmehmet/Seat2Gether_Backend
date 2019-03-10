using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.A_BBnr_Bemerkungen_Zuschnitt")]
    public class BBNRRemarksCut
    {
        [Column("BBNr", Order =1)]
        [Key]
        
        public string BBNRID { get; set; }
        
        [Column("Bemerkung", Order = 2)]
        [Key]
        public string Comment { get; set; }
    }
}