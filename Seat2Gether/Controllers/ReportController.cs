using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Seat2Gether.Controllers
{
    [RoutePrefix("api/Report")]
    public class ReportController : BaseController
    {
        private ReportService ReportService = null;

        public ReportController()
        {
            ReportService = new ReportService();
        }


        [Route("FindReportLogsByBBNR/{bbnr}")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindReportLogsByBBNR(string BBNR)
        {
            IHttpActionResult result = null;
            try { 
                result = Ok(ReportService.FindReportLogsByBBNR(BBNR));
            }catch(Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ReportLogController", "FindReportLogsByBBNR", E);
            }
            return result;
        }

        [Route("FindReportLogsByBBNRList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindReportLogsByBBNR(List<string> bbnrList)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(ReportService.FindReportLogsByBBNRList(bbnrList));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ReportLogController", "FindReportLogsByBBNR", E);
            }
            return result;
        }

        [Route("AddReportLog")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddReportLog(ReportLogDto ReportLogDto)
        {
            try
            {
                ReportService.AddReportLog(ReportLogDto);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "RoleController", "addRole", E);
            }

            return Ok("Role Successfully Created");

        }

        [Route("FindBBNRListBySearchBBNR")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult FindBBNRListBySearchBBNR(SearchBBNR searchBBNR)
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(ReportService.FindBBNRListBySearchBBNR(searchBBNR));
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "CutReportController", "ContentOne", E);
            }

            return result;
        }

    }
}