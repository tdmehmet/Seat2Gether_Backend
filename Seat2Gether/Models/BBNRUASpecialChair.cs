using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.Models
{
    public class BBNRUASpecialChair
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

        public string Hersteller { get; set; }
        public string Manufacturer
        {
            get
            {
                return Hersteller;
            }
            set
            {
                Manufacturer = Hersteller;
            }
        }

        public string Bemerkungen { get; set; }
        public string Remarks
        {
            get
            {
                return Bemerkungen;
            }
            set
            {
                Remarks = Bemerkungen;
            }
        }

        public string Bezug { get; set; }
        public string Reference
        {
            get
            {
                return Bezug;
            }
            set
            {
                Reference = Bezug;
            }
        }


        public string Ausführung { get; set; }
        public string Execution
        {
            get
            {
                return Ausführung;
            }
            set
            {
                Execution = Ausführung;
            }
        }

        public string Keder { get; set; }
        public string Edge_Reinforcement
        {
            get
            {
                return Keder;
            }
            set
            {
                Edge_Reinforcement = Keder;
            }
        }

        public string Kopfteil { get; set; }
        public string Headboard
        {
            get
            {
                return Kopfteil;
            }
            set
            {
                Headboard = Kopfteil;
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



    }
}