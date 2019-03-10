using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{

    [Table("dbo.T_Stammdaten")]
    public class VehicleMasterData
    {
        [Display(Name = "Fzgnummer")]
        [Column("Fzgnummer", Order = 0)]
        [Key]
        public string BBNRID { get; set; }

        [Display(Name = "Importdatum")]
        [Column("Importdatum", Order =1)]
        public Nullable<DateTime> ImportDate { get; set; }

        [Display(Name = "Typ")]
        [Column("Typ")]
        public string Type { get; set; }

        [Display(Name = "Kunde")]
        [Column("Kunde")]
        public string Customer { get; set; }

        [Display(Name = "Standort")]
        [Column("Standort")]
        public string Location { get; set; }

        [Display(Name = "Land")]
        [Column("Land")]
        public string Land { get; set; }

        [Display(Name = "Stuhltyp")]
        [Column("Stuhltyp")]
        public string SeatType { get; set; }

        [Display(Name = "Bemerkung")]
        [Column("Bemerkung")]
        public string Comment { get; set; }

        [Display(Name = "Sitzplätze")]
        [Column("Sitzplätze")]
        public Int32 SitsCount { get; set; }

        [Display(Name = "BE")]
        [Column("BE")]
        public Nullable<DateTime> BE { get; set; }

        [Display(Name = "Auftragseingang")]
        [Column("Auftragseingang")]
        public Nullable<DateTime> IncomingOrderDate { get; set; }

        [Display(Name = "Liefertermin")]
        [Column("Liefertermin")]
        public Nullable<DateTime> DeliveryDate { get; set; }

        [Display(Name = "Rückenkennzeichen")]
        [Column("Rückenkennzeichen")]
        public Int32 BackLabel { get; set; }

        [Display(Name = "Stoff")]
        [Column("Stoff")]
        public string Fabric { get; set; }

        [Display(Name = "STFB")]
        [Column("STFB")]
        public Int32 STFB { get; set; }

        [Display(Name = "STFA")]
        [Column("STFA")]
        public Int32 STFA { get; set; }

        [Display(Name = "SFTL")]
        [Column("SFTL")]
        public Int32 SFTL { get; set; }

        [Display(Name = "SFTS")]
        [Column("SFTS")]
        public Int32 SFTS { get; set; }

        [Display(Name = "Keder")]
        [Column("Keder")]
        public Int32 Piping { get; set; }

        [Display(Name = "Kissen_")]
        [Column("Kissen_")]
        public Int32 Pillow_ { get; set; }

        [Display(Name = "Fond")]
        [Column("Fond")]
        public Int32 BackSeat { get; set; }

        [Display(Name = "Zuschnitt")]
        [Column("Zuschnitt")]
        public Int32 Cutting { get; set; }

        [Display(Name = "Zuschnittdatum")]
        [Column("Zuschnittdatum")]
        public Nullable<DateTime> CuttingDate { get; set; }

        [Display(Name = "Zuschnittbemerkung")]
        [Column("Zuschnittbemerkung")]
        public string CuttingComment { get; set; }

        [Display(Name = "Zuschnitt_Zustand")]
        [Column("Zuschnitt_Zustand")]
        public string CuttingShape { get; set; }

        [Display(Name = "Nähen")]
        [Column("Nähen")]
        public Int32 Sewing { get; set; }

        [Display(Name = "Nähendatum")]
        [Column("Nähendatum")]
        public Nullable<DateTime> SewingDate { get; set; }

        [Display(Name = "Nähenbemerkung")]
        [Column("Nähenbemerkung")]
        public string SewingComment { get; set; }

        [Display(Name = "Nähen_Zustand")]
        [Column("Nähen_Zustand")]
        public string SewingShape { get; set; }

        [Display(Name = "Polsterei")]
        [Column("Polsterei")]
        public Int32 Upholstery { get; set; }

        [Display(Name = "Polstereibemerkung")]
        [Column("Polstereibemerkung")]
        public string UpholsteryComment { get; set; }

       // public String FZG_Per_RequestNumber { get; set; }

        [Display(Name = "Polstereidatum")]
        [Column("Polstereidatum")]
        public Nullable<DateTime> UpholsteryDate { get; set; }

        [Display(Name = "Polsterei_Zustand")]
        [Column("Polsterei_Zustand")]
        public string UpholsteryShape { get; set; }

        [Display(Name = "Kissen")]
        [Column("Kissen")]
        public Int32 Pillow { get; set; }
        
        [Display(Name = "Kissenbemerkung")]
        [Column("Kissenbemerkung")]
        public string PillowComment { get; set; }

        [Display(Name = "Kissendatum")]
        [Column("Kissendatum")]
        public Nullable<DateTime> PillowDate { get; set; }

        [Display(Name = "Kissen_Zustand")]
        [Column("Kissen_Zustand")]
        public string PillowShape { get; set; }


        [Display(Name = "Sitzmontage")]
        [Column("Sitzmontage")]
        public Int32 SitsMontage { get; set; }

        [Display(Name = "Sitzmontagebemerkung")]
        [Column("Sitzmontagebemerkung")]
        public string SitsMontageComment { get; set; }

        [Display(Name = "Sitzmontagedatum")]
        [Column("Sitzmontagedatum")]
        public Nullable<DateTime> SitsMontageDate { get; set; }

        [Display(Name = "Sitzmontage_Zustand")]
        [Column("Sitzmontage_Zustand")]
        public string SitsMontageShape { get; set; }


        [Display(Name = "Bemerkung_Fehlteile")]
        [Column("Bemerkung_Fehlteile")]
        public string BackfirePartsComment { get; set; }

        [Display(Name = "Termin_Fehlteile")]
        [Column("Termin_Fehlteile")]
        public Nullable<DateTime> BackfirePartsDeadline { get; set; }

        [Display(Name = "Zusammenbau_Datum")]
        [Column("Zusammenbau_Datum")]
        public Nullable<DateTime> AssemblyDate { get; set; }

        [Display(Name = "Zusammenbau_Reihenfolge")]
        [Column("Zusammenbau_Reihenfolge")]
        public Int32 AssemblySequence { get; set; }

        [Display(Name = "Fremdvergabe_Näherei")]
        [Column("Fremdvergabe_Näherei")]
        public string SewingOutsourceName { get; set; }

        [Display(Name = "Fremdvergabe_Näherei_Datum")]
        [Column("Fremdvergabe_Näherei_Datum")]
        public Nullable<DateTime> SewingOutsourceDate { get; set; }

        [Display(Name = "Fremdvergabe_Kissen")]
        [Column("Fremdvergabe_Kissen")]
        public string PillowOutsourceName { get; set; }

        [Display(Name = "Fremdvergabe_Kissen_Datum")]
        [Column("Fremdvergabe_Kissen_Datum")]
        public Nullable<DateTime> PillowOutsourceDate { get; set; }

        [Display(Name = "Fremdvergabe_Polsterei")]
        [Column("Fremdvergabe_Polsterei")]
        public string UpholsteryOutsourceName { get; set; }

        [Display(Name = "Fremdvergabe_Polsterei_Datum")]
        [Column("Fremdvergabe_Polsterei_Datum")]
        public Nullable<DateTime> UpholsteryOutsourceDate { get; set; }

        [Display(Name = "Bestuhlungszeichnung")]
        [Column("Bestuhlungszeichnung")]
        public string SeatingDesign { get; set; }

        [Display(Name = "letzter_Bereich")]
        [Column("letzter_Bereich")]
        public Int32 LastActArea { get; set; }

        [Display(Name = "Bemerkung_2")]
        [Column("Bemerkung_2")]
        public Int32 Comment2 { get; set; }
    }
}
      
  