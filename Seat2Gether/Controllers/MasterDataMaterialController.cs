using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Seat2Gether.Controllers
{

    [RoutePrefix("api/Material")]
    public class MasterDataMaterialController : BaseController
    {
        private MasterDataMaterialService materialService = null;

        public MasterDataMaterialController()
        {
            materialService = new MasterDataMaterialService();
        }


        [Route("MaterialList")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult MaterialList()
        {
            IHttpActionResult result = null;
            try
            {
                result = Ok(materialService.MaterialList());
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataMaterialController", "MaterialList", E);
            }

            return result;
        }

        [Route("addMaterial")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult AddMaterial(MasterDataMaterialDto material)
        {
            try
            {
                materialService.AddMaterial(material);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataMaterialController", "AddMaterial", E);
            }

            return Ok("Material Successfully Created");

        }

        [Route("updateMaterial")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult UpdateMaterial(MasterDataMaterialDto material)
        {
            try
            {
                materialService.UpdateMaterial(material);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataMaterialController", "UpdateMaterial", E);
            }

            return Ok("Material  Successfully Updated");
        }

        [Route("deleteMaterial")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult DeleteMaterial(MasterDataMaterialDto material)
        {
            try
            {
                materialService.DeleteMaterial(material);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "MasterDataMaterialController", "DeleteMaterial", E);
            }

            return Ok("Material Type Successfully Deleted");
        }
    }

}