using System;

namespace Seat2Gether.dto
{
    public class ReportLogDto
    {
        public string BBNR { get; set; }
        public string Deck { get; set; }
        public string ReportName { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportUser { get; set; }

        public ReportLogDto()
        {

        }

        public ReportLogDto(string BBNR, string Deck, string ReportName, DateTime ReportDate, string ReportUser)
        {
            this.BBNR = BBNR;
            this.Deck = Deck;
            this.ReportName = ReportName;
            this.ReportDate = ReportDate;
            this.ReportUser = ReportUser;
        }

    }
}