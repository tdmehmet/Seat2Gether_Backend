using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("dbo.T_ST_EB_Sitzgestell")]
    public class MasterDataSeatFrame
    {

        [Display(Name = "EB Number")]
        [Column("EB")]
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string EbNumber { get; set; }

        [Display(Name = "Designation")]
        [Column("Bezeichnung")]
        public string Designation { get; set; }

        [Display(Name ="TNR Support Tube")]
        [Column("TNR_Tragrohr")]
        public string TnrSupportTube { get; set; }

        [Display(Name = "Amount")]
        [Column("Menge")]
        public int Amount { get; set; }

        [Display(Name ="Template")]
        [Column("Schablone")]
        public int Template { get; set; }

        [Display(Name ="Seat Pitch")]
        [Column("Sitzabstand")]
        public double SeatPitch { get; set; }

        [Display(Name ="Page")]
        [Column("Seite")]
        public string Page { get; set; }

        [Display(Name ="Color Info")]
        [Column("Farbinfo")]
        public string ColorInfo { get; set; }

        [Display(Name = "Adapter")]
        [Column("Adapter")]
        public bool Adapter { get; set; }

    }
}