using Seat2Gether.dto;
using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class ReportRepository
    {
        private Seat2GetherDBContext DBContext;

        public ReportRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        /**
        * Finds report logs by bbnr
        **/
        public List<ReportLog> FindReportLogsByBBNR(string BBNR)
        {

            var reportLogQuery = from reportLog in DBContext.ReportLog
                             where reportLog.BBNR == BBNR
                             orderby reportLog.ReportDate descending
                             select reportLog;

            List<ReportLog> ReportLogList = reportLogQuery.ToList();
            return ReportLogList;
        }

        /**
        * Finds report logs by bbnr list
        **/
        public List<ReportLog> FindReportLogsByBBNRList(List<string> bbnrList)
        {

            var reportLogQuery = from reportLog in DBContext.ReportLog
                                 where bbnrList.Contains(reportLog.BBNR)
                                 orderby reportLog.ReportDate descending
                                 select reportLog;

            List<ReportLog> ReportLogList = reportLogQuery.ToList();
            return ReportLogList;
        }

        /**
        * Add new ReportLog
        **/
        public void AddReportLog(ReportLog reportLog)
        {
            DBContext.ReportLog.Add(reportLog);
            DBContext.SaveChanges();
        }

        /**
       * Add range of ReportLogs
       **/
        public void AddReportLogList(List<ReportLog> reportLogList)
        {
            DBContext.ReportLog.AddRange(reportLogList);
            DBContext.SaveChanges();
        }

        public List<BBNR> FindBBNRListBySearchBBNR(SearchBBNR searchBBNR)
        {

            var vehicleQuery = from bbnr in DBContext.BBNr
                                where (searchBBNR.BBNRID == null || bbnr.BBNRID.StartsWith(searchBBNR.BBNRID))
                            && (searchBBNR.OrderID == null || bbnr.OrderID.StartsWith(searchBBNR.OrderID))
                            && (searchBBNR.StartDate == null || searchBBNR.StartDate < bbnr.ToBe_Date)
                            && (searchBBNR.EndDate == null || searchBBNR.EndDate > bbnr.ToBe_Date)
                                select bbnr;

            List<BBNR> bbnrList = vehicleQuery.ToList();

            return bbnrList;
        }

        public BBNR FindBBNRByBBNR(string BBNR)
        {
            var BBNRQuery = from bbnr in DBContext.BBNr
                            where bbnr.BBNRID == BBNR
                            select bbnr;
            BBNR BBNRData = BBNRQuery.FirstOrDefault<BBNR>();
            return BBNRData;
        }

    }
}