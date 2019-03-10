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
    public class MasterDataSeatTypeService
    {
        private MasterDataSeatTypeRepository Repository = null;

        public MasterDataSeatTypeService()
        {
            Repository = new MasterDataSeatTypeRepository();
        }
        public List<ExMasterDataSeatTypeDto> GetList()
        {
            return Repository.GetList().ToList().CreateMappedList<ExMasterDataSeatType, ExMasterDataSeatTypeDto>();
        }
       
        public ExMasterDataSeatType Find(object Id)
        {
            return Repository.Find(Id);
        }
        public void Add(ExMasterDataSeatTypeDto entity)
        {
            Repository.Add(entity.CreateMapped<ExMasterDataSeatTypeDto, ExMasterDataSeatType>());
        }
        public void AddRange(List<ExMasterDataSeatTypeDto> entity)
        {
           
            Repository.AddRange(entity.CreateMappedList<ExMasterDataSeatTypeDto, ExMasterDataSeatType>());
        }
        public void Update(ExMasterDataSeatTypeDto entity)
        {
            Repository.Update(entity.CreateMapped<ExMasterDataSeatTypeDto, ExMasterDataSeatType>());
        }

        public void Delete(ExMasterDataSeatTypeDto entity)
        {
           
            Repository.Delete(entity.CreateMapped<ExMasterDataSeatTypeDto, ExMasterDataSeatType>());
        }
        public void Delete(params object[] keyValue)
        {
            var entity = Repository.Find(keyValue);
            Repository.Delete(entity);
        }
    }
}