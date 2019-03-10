using Seat2Gether.dto.ExternalDto;
using Seat2Gether.Models;
using Seat2Gether.Models.ExternalModels;
using Seat2Gether.Repositories;
using Seat2Gether.Repositories.ExternalRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services.ExternalServices
{
    public class MasterDataService
    {
        private MasterDataRepository Repository = null;

        public MasterDataService()
        {
            Repository = new MasterDataRepository();
        }
        public List<ExMasterDataDto> GetList()
        {
            return Repository.GetList().ToList().CreateMappedList<ExMasterData, ExMasterDataDto>();
        }
        public List<ExMasterDataDto> GetByTypeList(int masterDataTypeId)
        {
            return Repository.GetList().Where(k=>k.MasterDataTypeId== masterDataTypeId).ToList().CreateMappedList<ExMasterData, ExMasterDataDto>();
        }
        public ExMasterData Find(object Id)
        {
            return Repository.Find(Id);
        }
        public void Add(ExMasterDataDto entity)
        {
            Repository.Add(entity.CreateMapped<ExMasterDataDto, ExMasterData>());
        }
        public void AddRange(List<ExMasterDataDto> entity)
        {
           
            Repository.AddRange(entity.CreateMappedList<ExMasterDataDto, ExMasterData>());
        }
        public void Update(ExMasterDataDto entity)
        {
            Repository.Update(entity.CreateMapped<ExMasterDataDto, ExMasterData>());
        }

        public void Delete(ExMasterDataDto entity)
        {
           
            Repository.Delete(entity.CreateMapped<ExMasterDataDto, ExMasterData>());
        }
        public void Delete(params object[] keyValue)
        {
            var entity = Repository.Find(keyValue);
            Repository.Delete(entity);
        }
    }
}