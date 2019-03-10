using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class ReportService
    {
        private ReportRepository ReportRepository = null;

        public ReportService()
        {
            ReportRepository = new ReportRepository();
        }

        public List<ReportLogDto> FindReportLogsByBBNR(string BBNR)
        {
            List<ReportLogDto> ReportLogDtoList = new List<ReportLogDto>();
            List<ReportLog> ReportLogList = ReportRepository.FindReportLogsByBBNR(BBNR);

            ReportLogDtoList = ReportLogList.CreateMappedList<ReportLog, ReportLogDto>();
            
            return ReportLogDtoList;
        }

        public List<ReportLogDto> FindReportLogsByBBNRList(List<string> bbnrList)
        {
            List<ReportLogDto> ReportLogDtoList = new List<ReportLogDto>();
            List<ReportLog> ReportLogList = ReportRepository.FindReportLogsByBBNRList(bbnrList);

            ReportLogDtoList = ReportLogList.CreateMappedList<ReportLog, ReportLogDto>();

            return ReportLogDtoList;
        }

        public void AddReportLog(ReportLogDto ReportLogDto)
        {
            ReportLog ReportLog = ReportLogDto.CreateMapped<ReportLogDto, ReportLog>();
            if (ReportLogDto != null)
            {
                ReportRepository.AddReportLog(ReportLog);
            }
        }

        public void AddReportLogList(List<ReportLogDto> ReportLogDtoList)
        {
            List<ReportLog> ReportLogList = ReportLogDtoList.CreateMappedList<ReportLogDto, ReportLog>();
            if (ReportLogDtoList != null)
            {
                ReportRepository.AddReportLogList(ReportLogList);
            }
        }

        public List<BBNRDto> FindBBNRListBySearchBBNR(SearchBBNR searchBBNR)
        {

            List<BBNRDto> bbnrDTOList = new List<BBNRDto>();
            List<BBNR> bbnrList = ReportRepository.FindBBNRListBySearchBBNR(searchBBNR);

            bbnrDTOList = bbnrList.CreateMappedList<BBNR, BBNRDto>();

            return bbnrDTOList;
        }

        public BBNR FindBBNRByBBNR(string BBNR)
        {
            return ReportRepository.FindBBNRByBBNR(BBNR);
        }
    }
}


    