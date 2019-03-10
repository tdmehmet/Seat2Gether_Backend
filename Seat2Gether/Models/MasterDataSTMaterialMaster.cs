using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    [Table("T_ST_Materialstamm")]
    public class MasterDataSTMaterialMaster
    {
        [Display(Name = "PartNumber")]
        [Column("TNR")]
        [Key]
        public string PartNumber { get; set; }


        [Display(Name = "Designation")]
        [Column("Bezeichnung")]
        public string Designations { get; set; }


        [Display(Name = "LfdNr Characteristic")]
        [Column("lfdNr_Merkmal")]
        public int LfdNrCharacteristic { get; set; }

        [Display(Name = "Active")]
        [Column("aktiv")]
        public bool Active { get; set; }

        [Display(Name = "Created By")]
        [Column("angelegt_von")]
        public string CreatedBy { get; set; }

        [Display(Name = "angelegt_am")]
        [Column("angelegt_am")]
        public DateTime Created_On { get; set; }

        [Display(Name = "Altered From")]
        [Column("geändert_von")]
        public string AlteredFrom { get; set; }

        [Display(Name = "Changed On")]
        [Column("geändert_am")]
        public Nullable<DateTime> ChangedOn { get; set; }

        [Display(Name = "Area")]
        [Column("Bereich")]
        public int Area { get; set; }

        [Display(Name = "Designation Report")]
        [Column("Bezeichnung_Bericht")]
        public string DesignationReport { get; set; }

        [Display(Name = "Issue Label")]
        [Column("Ausgabe_Etikett")]
        public bool IssueLabel { get; set; }

        [Display(Name = "Column Report ")]
        [Column("Spalte_Bericht_Sonderstuhl")]
        public Nullable<int> ColumnReportSpecialSeat { get; set; }

        [Display(Name = "Issue Report")]
        [Column("Ausgabe_Bericht_Sonderstuhl")]
        public string IssueReport { get; set; }

        [Display(Name = "Line Report Circus")]
        [Column("Zeile_Bericht_Rondell")]
        public Nullable<int> LineReportCircus { get; set; }

        [Display(Name = "Issue Report Circus")]
        [Column("Ausgabe_Bericht_Rondell")]
        public string IssueReportCircus { get; set; }

        [Display(Name = "Column SSFNS")]
        [Column("Spalte_SSFNS")]
        public Nullable<int> ColumnSSFNS { get; set; }

        [Display(Name = "Issue SSFNS")]
        [Column("Ausgabe_SSFNS")]
        public string IssueSSFNS { get; set; }

        [Display(Name = "Column SSFS")]
        [Column("Spalte_SSFS")]
        public Nullable<int> ColumnSSFS { get; set; }

        [Display(Name = "Issue SSFS")]
        [Column("Ausgabe_SSFS")]
        public string IssueSSFS { get; set; }

        [Display(Name = "Label Text")]
        [Column("Etikettentext")]
        public string LabelText { get; set; }


        [Display(Name = "UGR")]
        [Column("UGR")]
        public string UGR { get; set; }

        [Display(Name = "KSW")]
        [Column("KSW")]
        public bool KSW { get; set; }

        
    }
}