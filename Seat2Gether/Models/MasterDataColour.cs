using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seat2Gether.Models
{

    [Table("T_Farbauswahl")]
    public class MasterDataColour
    {
        [Display(Name = "lfdNr_Farbe")]
        [Column("lfdNr_Farbe")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int32 ColourIndex { get; set; }

        [Display(Name = "Farbe")]
        [Column("Farbe")]
        public string Colour { get; set; }

        [Display(Name = "QBColor")]
        [Column("QBColor")]
        public Int32 QBColour { get; set; }

    }
}