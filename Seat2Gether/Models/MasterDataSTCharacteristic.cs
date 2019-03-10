using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_ST_Merkmal")]
    public class MasterDataSTCharacteristic
    {

        [Display(Name = "LfdNr Characteristic")]
        [Column("lfdNr_Merkmal")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LfdNrCharacteristic { get; set; }

        [Display(Name = "Characteristic")]
        [Column("Merkmal")]
        public string Characteristic { get; set; }

        [Display(Name = "Sort")]
        [Column("Sort")]
        public Int64 Sort { get; set; }

        [Display(Name = "LfdNrPot")]
        [Column("lfdNr_Topf")]
        public int LfdNrPot { get; set; }

        [Display(Name = "Cut")]
        [Column("Zuschnitt")]
        public bool Cut { get; set; }

        [Display(Name = "Stitching")]
        [Column("Näherei")]
        public bool Stitching { get; set; }

        [Display(Name = "Special Seat")]
        [Column("Sonderstuhl")]
        public bool SpecialSeat { get; set; }


        [Display(Name = "Montage")]
        [Column("Montage")]
        public bool Montage { get; set; }

        [Display(Name = "Issue Circus")]
        [Column("Ausgabe_Rondell")]
        public bool IssueCircus { get; set; }

        [Display(Name = "Issue UGS")]
        [Column("Ausgabe_UGS")]
        public bool IssueUGS { get; set; }

        [Display(Name = "Material Relevant")]
        [Column("Stoffrelevant")]
        public bool MaterialRelevant { get; set; }

        [Display(Name = "C2")]
        [Column("C2")]
        public string C2 { get; set; }

    }
}
