using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    public class BBNRUASpecialChairPartsList
    {
        //Sonderstuhl Report Button Model

        public string AUftragsNr { get; set; }
        public string OrderID
        {
            get
            {
                return AUftragsNr;
            }
            set
            {
                OrderID = AUftragsNr;
            }
        }

        public string TNR { get; set; }
        public string PartNumber
        {
            get
            {
                return TNR;
            }
            set
            {
                PartNumber = TNR;
            }
        }

        public string Bezeichnung { get; set; }
        public string Designation
        {
            get
            {
                return Bezeichnung;
            }
            set
            {
                Designation = Bezeichnung;
            }
        }

        public int Menge { get; set; }
        public int Amount
        {
            get
            {
                return Menge;
            }
            set
            {
                Amount = Menge;
            }
        }


        public string Farbe { get; set; }
        public string Colour
        {
            get
            {
                return Farbe;
            }
            set
            {
                Colour = Farbe;
            }
        }

        public int Lfdnr_Merkmal { get; set; }
        public int Lfdnr_Characteristic
        {
            get
            {
                return Lfdnr_Merkmal;
            }
            set
            {
                Lfdnr_Characteristic = Lfdnr_Merkmal;
            }
        }

        

      
    }
}