using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("T_ST_EB_Gurt")]
    public class MasterDataEBBelt
    {
        [Display(Name = "EB")]
        [Column("EB")]
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string EB { get; set; }


        [Display(Name = "Designation")]
        [Column("Bezeichnung")]
        public string Designation { get; set; }


        [Display(Name = "Link")]
        [Column("links")]
        public string Link { get; set; }

        [Display(Name = "Right")]
        [Column("rechts")]
        public string Right { get; set; }


        [Display(Name = "Program")]
        [Column("Programm")]
        public string Program { get; set; }


        [Display(Name = "DS Characteristic")]
        [Column("DS_Merkmal")]
        public string DSCharacteristic { get; set; }


        [Display(Name = "Number Of Back")]
        [Column("Anzahl_Rücken")]
        public int NumberOfBack { get; set; }


        [Display(Name = "Arrangement")]
        [Column("Gruppierung")]
        public Nullable<int> Arrangement { get; set; }
                
    }
}