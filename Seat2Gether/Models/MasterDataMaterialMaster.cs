using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_Materialstamm")]
    public class MasterDataMaterialMaster
    {
        [Display(Name = "lfdNr Material")]
        [Column("lfdNr_Material")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lfdnrMaterial { get; set; }

        [Display(Name = "PartNumber")]
        [Column("TNR")]
        public string PartNumber { get; set; }

        [Display(Name = "Designation")]
        [Column("Bezeichnung")]
        public string Designation { get; set; }

        [Display(Name = "Position")]
        [Column("Position")]
        public string Position { get; set; }

        [Display(Name = "lfdnr Characteristic")]
        [Column("lfdNr_Merkmal")]
        public int lfdnrCharacteristic { get; set; }

        [Display(Name = "Standard Time in Munite")]
        [Column("Vorgabezeit_in_Minuten")]
        public double standardTimeInMinute { get; set; }

        [Display(Name = "VZKO")]
        [Column("VZ_KO")]
        public double VZKO { get; set; }

        [Display(Name = "BW")]
        [Column("VZ_BW")]
        public double VZBW { get; set; }

        [Display(Name = "EL")]
        [Column("VZ_EL")]
        public double VZEL { get; set; }

        [Display(Name = "AZ")]
        [Column("VZ_AZ")]
        public double VZAZ { get; set; }

        [Display(Name = "VS")]
        [Column("VZ_VS")]
        public double VZVS { get; set; }

        [Display(Name = "MO")]
        [Column("VZ_MO")]
        public double VZMO { get; set; }

        [Display(Name = "AL")]
        [Column("VZ_AL")]
        public double VZAL { get; set; }

        [Display(Name = "GF")]
        [Column("VZ_GF")]
        public double VZGF { get; set; }

        [Display(Name = "Standart")]
        [Column("Standard")]
        public bool Standart { get; set; }

        [Display(Name = "Active")]
        [Column("aktiv")]
        public bool Active { get; set; }

        [Display(Name = "Created By")]
        [Column("angelegt_von")]
        public string CreatedBy { get; set; }

        [Display(Name = "Created On")]
        [Column("angelegt_am")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Altered From")]
        [Column("geändert_von")]
        public string AlteredFrom { get; set; }

        [Display(Name = "Changed On")]
        [Column("geändert_am")]
        public Nullable<DateTime> ChangedOn { get; set; }

        [Display(Name = "Bulk Good")]
        [Column("Schüttgut")]
        public bool BulkGood { get; set; }

        [Display(Name = "Number Additional Share")]
        [Column("Anzahl_Zusatzteile")]
        public Nullable<int> NumberAdditionalShare { get; set; }

        [Display(Name = "Background")]
        [Column("HIntergrund")]
        public string Background { get; set; }

        [Display(Name = "Foreground")]
        [Column("Vordergrund")]
        public string Foreground { get; set; }

        [Display(Name = "Pos X")]
        [Column("Pos_X")]
        public int PosX { get; set; }

        [Display(Name = "Pos Y")]
        [Column("Pos_Y")]
        public int PosY { get; set; }

        [Display(Name = "Picture")]
        [Column("Bild")]
        public string Picture { get; set; }

        [Display(Name = "Acquisition Variation")]
        [Column("Bezugsvariante")]
        public string AcquisitionVariation { get; set; }

        [Display(Name = "PartNumber Without")]
        [Column("TNR_ohne")]
        public string PartNumberWithout { get; set; }
    }
}