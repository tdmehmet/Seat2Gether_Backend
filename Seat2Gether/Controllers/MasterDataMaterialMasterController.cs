using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.services;
using System;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/MaterialMaster")]
    public class MasterDataMaterialMasterController : BaseController
    {
        private MasterDataMaterialMasterService MaterialMasterButtonService = null;

        public MasterDataMaterialMasterController()
        {
            MaterialMasterButtonService = new MasterDataMaterialMasterService();
        }


        [Route("MaterialMasterList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult MaterialMasterList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(MaterialMasterButtonService.MaterialMasterList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataMaterialMasterController", "MaterialMasterList", E);
            }

            return result;
        }

        [Route("addMaterialMaster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddMaterialMaster(MasterDataMaterialMaster materialMaster)
        {
            try
            {
                MaterialMasterButtonService.AddMaterialMaster(materialMaster);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataMaterialMasterController", "addMaterialMaster", E);
            }
            
            return Ok("Material Master Successfully Created");
        }

        [Route("deleteMaterialMaster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteMaterialMaster(MasterDataMaterialMaster materialMaster)
        {
            try
            {
                MaterialMasterButtonService.DeleteMaterialMaster(materialMaster);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataMaterialMasterController", "deleteMaterialMaster", E);
            }

            return Ok("Material Master Successfully Deleted");
        }

        [Route("updateMaterialMaster")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateMaterialMaster(MasterDataMaterialMaster materialMaster)
        {
            try
            {
                MaterialMasterButtonService.UpdateMaterialMaster(materialMaster);
            }
            catch (Exception E)
            {

                throw new Seat2GetherExceptionWithCode("1", "MasterDataMaterialMasterController", "updateMaterialMaster", E);
            }

            return Ok("Material Master Successfully Updated");
        }



    }
}