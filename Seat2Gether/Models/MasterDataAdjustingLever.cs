using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("T_ST_Verstellhebel")]
    public class MasterDataAdjustingLever
    {
        [Display(Name = "PartNumber")]
        [Column("TNR")]
        [Key]
        public string PartNumber { get; set; }


        [Display(Name = "Number Of Blocking")]
        [Column("Anzahl_Blockierung")]
        public int NumberOfBlocking { get; set; }


        [Display(Name = "Designation")]
        [Column("Bezeichnung")]
        public string Designation { get; set; }

        [Display(Name = "Page")]
        [Column("Seite")]
        public string Page { get; set; }

    }
}