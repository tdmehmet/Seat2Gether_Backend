using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{


    [RoutePrefix("api/BackrestAdjuster")]
    public class MasterDataBackrestAdjusterController : BaseController
    {
        private MasterDataBackrestAdjusterService BackrestAdjusterButtonService = null;

        public MasterDataBackrestAdjusterController()
        {
            BackrestAdjusterButtonService = new MasterDataBackrestAdjusterService();
        }


        [Route("BackrestAdjusterList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult BackrestAdjusterList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(BackrestAdjusterButtonService.BackrestAdjusterList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataBackrestAdjusterController", "BackrestAdjusterList", E);
            }

            return result;
        }

        [Route("addBackrestAdjuster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddBackrestAdjustert(MasterDataBackrestAdjusterDto backrestAdjuster)
        {
            try
            {
                BackrestAdjusterButtonService.AddBackrestAdjuster(backrestAdjuster);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataBackrestAdjusterController", "addBackrestAdjustert", E);
            }
            
            return Ok("Backrest Adjuster Successfully Created");

        }

        [Route("updateBackrestAdjuster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateBackrestAdjuster(MasterDataBackrestAdjusterDto backrestAdjuster)
        {
            try
            {
                BackrestAdjusterButtonService.UpdateBackrestAdjuster(backrestAdjuster);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataBackrestAdjusterController", "updateBackrestAdjuster", E);
            }
            
            return Ok("Backrest Adjuster Successfully Updated");
        }

        [Route("deleteBackrestAdjuster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteBackrestAdjuster(MasterDataBackrestAdjusterDto backrestAdjuster)
        {
            try
            {
                BackrestAdjusterButtonService.DeleteBackrestAdjuster(backrestAdjuster);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataBackrestAdjusterController", "deleteBackrestAdjuster", E);
            }
            
            return Ok("Backrest Adjuster Type Successfully Deleted");
        }
    }
}
