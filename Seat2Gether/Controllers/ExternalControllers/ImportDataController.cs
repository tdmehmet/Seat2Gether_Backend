using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Exceptions;
using Seat2Gether.Models.ExternalModels;
using Seat2Gether.services.ExternalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace Seat2Gether.Controllers.ExternalControllers
{
    [RoutePrefix("api/ImportData")]
    public class ImportDataController : ApiController
    {
        private FileParserService fileParserService;
        private MaterialService materialService;

        public ImportDataController()
        {
            fileParserService = new FileParserService();
            materialService = new MaterialService();
        }

        [Route("UploadFile")]
        [HttpPost]
        [Authorize]
        public async Task<IHttpActionResult> UploadFile()
        {
            try
            {

                if (!Request.Content.IsMimeMultipartContent())
                {
                    return StatusCode(HttpStatusCode.UnsupportedMediaType);
                }
                var filesReadToProvider = await Request.Content.ReadAsMultipartAsync();
                var stream = filesReadToProvider.Contents.FirstOrDefault();
                var fileBytes = await stream.ReadAsByteArrayAsync();
                var user = (User as ClaimsPrincipal).Claims.FirstOrDefault(k => k.Type == "sub").Value;
                var materialList = fileParserService.FileParseAndSave(fileBytes,user);
                return Ok(materialList);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ImportDataController", "UploadFile", E);
            }
        }

        [Route("SaveMaterials")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult SaveMaterials(ExMaterialGroupByVehicleDto data)
        {
            try
            {
                materialService.SaveMaterials(data);
                return Ok(data);
            }
            catch (Exception E)
            {
                throw new Seat2GetherExceptionWithCode("1", "ImportDataController", "SaveMaterials", E);
            }
        }

        [Route("UploadFileForBBnumber/{bbNumber}")]
        [HttpPost]
        [Authorize]
        public async Task<IHttpActionResult> UploadFileForBBnumber(string bbNumber)
        {
            try
            {
                if (!Request.Content.IsMimeMultipartContent())
                {
                    return StatusCode(HttpStatusCode.UnsupportedMediaType);
                }
                var filesReadToProvider = await Request.Content.ReadAsMultipartAsync();
                var stream = filesReadToProvider.Contents.FirstOrDefault();
                var fileBytes = await stream.ReadAsByteArrayAsync();
                var materialList = fileParserService.FileParseAndSaveForBBNumber(bbNumber, fileBytes);
                return Ok(materialList);
            }
            catch (Exception ex)
            {
                throw new Seat2GetherExceptionWithCode("1", "ImportDataController", "UploadFileForBBnumber", ex);
            }
        }
    }
}
